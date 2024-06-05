using System.Net;
using System.Text.Json;

namespace APP_API.Middleware
{
	public class ExceptionHandlingMiddleware
	{
		private readonly RequestDelegate _next;
		private readonly ILogger<ExceptionHandlingMiddleware> _logger;

		public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
		{
			_next = next;
			_logger = logger;
		}

		public async Task InvokeAsync(HttpContext context)
		{
			try
			{
				await _next(context);  // Chuyển yêu cầu đến middleware tiếp theo hoặc controller
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An unhandled exception has occurred.");
				await HandleExceptionAsync(context, ex);  // Xử lý ngoại lệ nếu có
			}
		}

		private static Task HandleExceptionAsync(HttpContext context, Exception exception)
		{
			context.Response.ContentType = "application/json";
			context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

			var result = JsonSerializer.Serialize(new { error = exception.Message });
			return context.Response.WriteAsync(result);  // Trả về phản hồi lỗi
		}
	}
}


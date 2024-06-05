using APP_DATA.Context;
using APP_DATA.Entity;
using APP_Service.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_Service.Repositories.Implementations
{
	internal class VoucherRepository : GenericRepository<Voucher>, IVoucherRepository
	{
		public VoucherRepository(MyContext context) : base(context)
		{
		}
	}
}

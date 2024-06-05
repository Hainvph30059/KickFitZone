using APP_Service.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_Service.Repositories.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IAddressRepository Address { get; }
        IBillRepository Bill { get; }
        ICustomerRepository Customer { get; }
        IEmployeeRepository Employee { get; }
        IProductRepository Product { get; }
        IBillStatusHistoryRepository BillStatusHistory { get; }
        ICartRepository Cart { get; }
        ICartDetailRepository CartDetail { get; }
        IColorRepository Color { get; }
        IImageRepository Image { get; }
        IMaterialRepository Material { get; }
        IPurchaseMethodRepository PurchaseMethod { get; }
        IRoleRepository Role { get; }
        ISexRepository Sex { get; }
        IShoesDetailRepository ShoesDetail  { get; }
        ISizeRepository Size { get; }
        IStyleRepository Style { get; }
        IVoucherRepository Voucher { get; }
        IBillDetailsRepository BillDetails { get; }
        int Save();
    }
}

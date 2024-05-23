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
        int Save();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APP_DATA.Context;
using APP_DATA.Entity;
using APP_Service.Repositories.Interfaces;

namespace APP_Service.Repositories.Implementations
{
	internal class PurcharMethodRepository : GenericRepository<PurchaseMethod>, IPurchaseMethodRepository
	{
		public PurcharMethodRepository(MyContext context) : base(context)
		{
		}
	}
}

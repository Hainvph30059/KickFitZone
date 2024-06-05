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
	internal class ShoesDetailsRepository : GenericRepository<ShoesDetails>, IShoesDetailRepository
	{
		public ShoesDetailsRepository(MyContext context) : base(context)
		{
		}
	}
}

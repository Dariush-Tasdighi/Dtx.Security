//using System.Linq;
//using Microsoft.EntityFrameworkCore;

namespace Data
{
	public class ApplicationRepository : Base.Repository<Models.Application>, IApplicationRepository
	{
		internal ApplicationRepository(DatabaseContext databaseContext) : base(databaseContext)
		{
		}
	}
}

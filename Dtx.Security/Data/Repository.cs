//using System.Linq;
//using Microsoft.EntityFrameworkCore;

namespace Data
{
	public class Repository<T> : Base.Repository<T> where T : Models.Base.Entity
	{
		internal Repository(DatabaseContext databaseContext) : base(databaseContext)
		{
		}
	}
}

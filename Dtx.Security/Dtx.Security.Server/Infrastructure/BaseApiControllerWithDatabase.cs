namespace Infrastructure
{
	public class BaseApiControllerWithDatabase : BaseApiController
	{
		public BaseApiControllerWithDatabase(Data.DatabaseContext databaseContext) : base()
		{
			MyDatabaseContext = databaseContext;
		}

		protected Data.DatabaseContext MyDatabaseContext { get; }
	}
}

namespace Infrastructure
{
	public class BaseApiControllerWithDatabase : BaseApiController
	{
		public BaseApiControllerWithDatabase(Data.IUnitOfWork unitOfWork) : base()
		{
			UnitOfWork = unitOfWork;
		}

		protected Data.IUnitOfWork UnitOfWork { get; }
	}
}

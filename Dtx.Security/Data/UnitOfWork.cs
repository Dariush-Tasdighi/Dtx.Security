namespace Data
{
	public class UnitOfWork : Base.UnitOfWork, IUnitOfWork
	{
		//public UnitOfWork() : base()
		//{
		//}

		public UnitOfWork(Tools.Options options) : base(options)
		{
		}

		// **************************************************
		//private IXXXXXRepository _xXXXXRepository;

		//public IXXXXXRepository XXXXXRepository
		//{
		//	get
		//	{
		//		if (_xXXXXRepository == null)
		//		{
		//			_xXXXXRepository =
		//				new XXXXXRepository(DatabaseContext);
		//		}

		//		return _xXXXXRepository;
		//	}
		//}
		// **************************************************

		// **************************************************
		private IUserRepository _userRepository;

		public IUserRepository UserRepository
		{
			get
			{
				if (_userRepository == null)
				{
					_userRepository =
						new UserRepository(DatabaseContext);
				}

				return _userRepository;
			}
		}
		// **************************************************

		// **************************************************
		private IApplicationRepository _applicationRepository;

		public IApplicationRepository ApplicationRepository
		{
			get
			{
				if (_applicationRepository == null)
				{
					_applicationRepository =
						new ApplicationRepository(DatabaseContext);
				}

				return _applicationRepository;
			}
		}
		// **************************************************
	}
}

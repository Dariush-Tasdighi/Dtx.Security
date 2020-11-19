﻿namespace Data
{
	public interface IUnitOfWork : Base.IUnitOfWork
	{
		// **********
		IUserRepository UserRepository { get; }
		// **********

		// **********
		IApplicationRepository ApplicationRepository { get; }
		// **********

		// **********
		IPermissionRepository PermissionRepository { get; }
		// **********

		// **********
		IApplicationEntityRepository ApplicationEntityRepository { get; }
		// **********

		// **********
		IApplicationGroupRepository ApplicationGroupRepository { get; }
		// **********
	}
}

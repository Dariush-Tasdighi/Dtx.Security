﻿using Data.Tools;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Data.Base
{
	public abstract class UnitOfWork : object, IUnitOfWork
	{
		//public UnitOfWork() : base()
		//{
		//}

		public UnitOfWork(Tools.Options options) : base()
		{
			Options = options;
		}

		#region MyRegion
		private Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction _transaction;

		public void BeginTransaction()
		{
			_transaction = _databaseContext.Database.BeginTransaction();
		}

		public void Commit()
		{
			try
			{
				_transaction.Commit();
			}
			finally
			{
				_transaction.Dispose();
			}
		}

		public void Rollback()
		{
			_transaction.Rollback();
			_transaction.Dispose();
		}
		#endregion
		// **********
		protected Tools.Options Options { get; set; }
		// **********

		// **********
		// **********
		// **********
		private DatabaseContext _databaseContext;
		// **********

		// **********
		/// <summary>
		/// Lazy Loading = Lazy Initialization
		/// </summary>
		internal DatabaseContext DatabaseContext
		{
			get
			{
				if (_databaseContext == null)
				{
					var optionsBuilder =
						new DbContextOptionsBuilder<DatabaseContext>();

					//switch(Options.Provider)
					//{
					//	case Provider.SqlServer:
					//	{
					//		optionsBuilder.UseSqlServer
					//			(connectionString: Options.ConnectionString);

					//		break;
					//	}

					//	case Provider.MySql:
					//	{
					//		optionsBuilder.UseMySql
					//			(connectionString: Options.ConnectionString);

					//		break;
					//	}
					//}

					if (Options.InMemoryDatabase)
					{
						//optionsBuilder.UseInMemoryDatabase<DatabaseContext>();
					}
					else
					{
						optionsBuilder.UseSqlServer(connectionString: Options.ConnectionString);
					}

					_databaseContext =
						new DatabaseContext(options: optionsBuilder.Options);
				}

				return _databaseContext;
			}
		}
		// **********
		// **********
		// **********

		Repository<T> IUnitOfWork.GetRepository<T>()
		{
			return new Repository<T>(databaseContext: DatabaseContext);
		}

		public virtual void Save()
		{
			DatabaseContext.SaveChanges();
		}

		public virtual async System.Threading.Tasks.Task SaveAsync()
		{
			await DatabaseContext.SaveChangesAsync();
		}

		// **********
		/// <summary>
		/// To detect redundant calls
		/// </summary>
		public bool IsDisposed { get; protected set; }
		// **********

		/// <summary>
		/// Public implementation of Dispose pattern callable by consumers.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);

			System.GC.SuppressFinalize(this);
		}

		/// <summary>
		/// https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/implementing-dispose
		/// </summary>
		protected virtual void Dispose(bool disposing)
		{
			if (IsDisposed)
			{
				return;
			}

			if (disposing)
			{
				// TODO: dispose managed state (managed objects).

				if (_databaseContext != null)
				{
					_databaseContext.Dispose();
					_databaseContext = null;
				}
			}

			// TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
			// TODO: set large fields to null.

			IsDisposed = true;
		}

		~UnitOfWork()
		{
			Dispose(false);
		}
	}
}

using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Data.Base
{
	public class Repository<T> : object, IRepository<T> where T : Models.Base.Entity
		//public abstract class Repository<T> : object, IRepository<T> where T : Models.Base.Entity
	{
		internal Repository(DatabaseContext databaseContext) : base()
		{
			// **************************************************
			//if (databaseContext == null)
			//{
			//	throw new System.ArgumentNullException(paramName: "databaseContext");
			//	throw new System.ArgumentNullException(paramName: "databaseContextSouti");
			//}

			//DatabaseContext = databaseContext;
			// **************************************************

			// **************************************************
			//if (databaseContext == null)
			//{
			//	throw new System.ArgumentNullException(paramName: nameof(databaseContext));
			//}

			//DatabaseContext = databaseContext;
			// **************************************************

			// **************************************************
			DatabaseContext =
				databaseContext ?? throw new System.ArgumentNullException(paramName: nameof(databaseContext));
			// **************************************************

			DbSet = DatabaseContext.Set<T>();
		}

		// **********
		internal DatabaseContext DatabaseContext { get; }
		//internal DatabaseContext DatabaseContext { get; set; }
		// **********

		// **********
		internal Microsoft.EntityFrameworkCore.DbSet<T> DbSet { get; }
		//internal Microsoft.EntityFrameworkCore.DbSet<T> DbSet { get; set; }
		// **********

		public virtual void Insert(T entity)
		{
			if (entity == null)
			{
				throw new System.ArgumentNullException(paramName: nameof(entity));
			}

			DbSet.Add(entity);
		}

		public virtual async System.Threading.Tasks.Task InsertAsync(T entity)
		{
			if (entity == null)
			{
				throw new System.ArgumentNullException(paramName: nameof(entity));
			}

			await DbSet.AddAsync(entity);
		}

		public virtual void Update(T entity)
		{
			if (entity == null)
			{
				throw new System.ArgumentNullException(paramName: nameof(entity));
			}

			DbSet.Update(entity);

			//Microsoft.EntityFrameworkCore.EntityState
			//	entityState = DatabaseContext.Entry(entity).State;

			//if (entityState == Microsoft.EntityFrameworkCore.EntityState.Detached)
			//{
			//	DbSet.Attach(entity);
			//}

			////entityState =
			////	DatabaseContext.Entry(entity).State;

			////DatabaseContext.Entry(entity).State =
			////	Microsoft.EntityFrameworkCore.EntityState.Modified;

			////entityState =
			////	DatabaseContext.Entry(entity).State;

			//_ =
			//	DatabaseContext.Entry(entity).State;

			//DatabaseContext.Entry(entity).State =
			//	Microsoft.EntityFrameworkCore.EntityState.Modified;

			//_ =
			//	DatabaseContext.Entry(entity).State;
		}

		public virtual async System.Threading.Tasks.Task UpdateAsync(T entity)
		{
			if (entity == null)
			{
				throw new System.ArgumentNullException(paramName: nameof(entity));
			}

			//DbSet.Update(entity);

			await System.Threading.Tasks.Task.Run(() =>
			{
				DbSet.Update(entity);
			});
		}

		public virtual void Delete(T entity)
		{
			if (entity == null)
			{
				throw new System.ArgumentNullException(paramName: nameof(entity));
			}

			DbSet.Remove(entity);

			//Microsoft.EntityFrameworkCore.EntityState
			//	entityState = DatabaseContext.Entry(entity).State;

			//if (entityState == Microsoft.EntityFrameworkCore.EntityState.Detached)
			//{
			//	DbSet.Attach(entity);
			//}

			//entityState =
			//	DatabaseContext.Entry(entity).State;

			//DbSet.Remove(entity);

			//entityState =
			//	DatabaseContext.Entry(entity).State;
		}

		public virtual async System.Threading.Tasks.Task DeleteAsync(T entity)
		{
			if (entity == null)
			{
				throw new System.ArgumentNullException(paramName: nameof(entity));
			}

			await System.Threading.Tasks.Task.Run(() =>
			{
				DbSet.Remove(entity);
			});
		}

		public virtual T GetById(System.Guid id)
		{
			return DbSet.Find(keyValues: id);
		}

		public virtual async System.Threading.Tasks.Task<T> GetByIdAsync(System.Guid id)
		{
			return await DbSet.FindAsync(keyValues: id);
		}

		public virtual bool DeleteById(System.Guid id)
		{
			T entity = GetById(id);

			if (entity == null)
			{
				return false;
			}

			Delete(entity);

			return true;
		}

		public virtual async System.Threading.Tasks.Task<bool> DeleteByIdAsync(System.Guid id)
		{
			T entity =
				await GetByIdAsync(id);

			if (entity == null)
			{
				return false;
			}

			await DeleteAsync(entity);

			return true;
		}

		public virtual System.Collections.Generic.IList<T> GetAll()
		{
			//return DbSet.ToList();

			var result =
				DbSet.ToList()
				;

			return result;
		}

		public virtual async System.Threading.Tasks.Task<System.Collections.Generic.IList<T>> GetAllAsync()
		{
			//return await DbSet.ToListAsync();

			var result =
				await
				DbSet.ToListAsync()
				;

			return result;

		}
	}
}

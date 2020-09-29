﻿//using System.Linq;
//using Microsoft.EntityFrameworkCore;

namespace Data
{
	public class Repository<T> : Base.Repository<T> where T : Models.Base.Entity
	{
		internal Repository(DatabaseContext databaseContext) : base(databaseContext)
		{
		}

		public override void Insert(T entity)
		{
			//base.Insert(entity);

			if (entity == null)
			{
				throw new System.ArgumentNullException(paramName: nameof(entity));
			}

			entity.InsertDateTime = Models.Utility.Now;

			DbSet.Add(entity);
		}
	}
}

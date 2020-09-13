namespace Data.Base
{
	public interface IRepository<T> where T : Models.Base.Entity
	{
		void Insert(T entity);

		System.Threading.Tasks.Task InsertAsync(T entity);

		void Update(T entity);

		System.Threading.Tasks.Task UpdateAsync(T entity);

		void Delete(T entity);

		System.Threading.Tasks.Task DeleteAsync(T entity);

		T GetById(System.Guid id);

		System.Threading.Tasks.Task<T> GetByIdAsync(System.Guid id);

		bool DeleteById(System.Guid id);

		System.Threading.Tasks.Task<bool> DeleteByIdAsync(System.Guid id);

		/// <summary>
		/// حضور این تابع اصلا حرفه‌ای نیست
		/// </summary>
		/// <returns></returns>
		//System.Linq.IQueryable<T> Get();

		System.Collections.Generic.IList<T> GetAll();

		System.Threading.Tasks.Task<System.Collections.Generic.IList<T>> GetAllAsync();
	}
}

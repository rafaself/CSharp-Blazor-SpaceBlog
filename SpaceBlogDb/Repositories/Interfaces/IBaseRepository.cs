using SpaceBlogDb.Models.Interfaces;

namespace SpaceBlogDb.Repositories.Interfaces;

public interface IBaseRepository<TEntity> where TEntity : class, IBaseModel
{
	public void Add(TEntity entity);
}

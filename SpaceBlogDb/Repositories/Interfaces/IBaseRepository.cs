namespace SpaceBlogDb.Repositories.Interfaces;

public interface IBaseRepository<TEntity> where TEntity : class
{
	public void Add(TEntity entity);
}

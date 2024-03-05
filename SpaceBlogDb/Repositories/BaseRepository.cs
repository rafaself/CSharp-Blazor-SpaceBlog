using SpaceBlogDb.Models.Interfaces;
using SpaceBlogDb.Repositories.Interfaces;

namespace SpaceBlogDb.Repositories;

public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, IBaseModel
{
	protected CustomDbContext _dbContext;

    public BaseRepository(CustomDbContext dbContext)
    {
		_dbContext = dbContext;
	}

    public void Add(TEntity entity)
	{
		_dbContext.Add(entity);
	}
}

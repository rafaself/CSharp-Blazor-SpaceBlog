using SpaceBlogDb.Models;
using SpaceBlogDb.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBlogDb.Repositories;

public class PostsRepository : BaseRepository<Post>
{
    public PostsRepository(CustomDbContext dbContext) : base(dbContext)
    {
    }
}

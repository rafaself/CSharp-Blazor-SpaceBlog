using SpaceBlogDb.Models;
using SpaceBlogDb.Repositories;

namespace SpaceBlogDb.UsesCases;

public class PostUseCases
{
	public static async Task Create(Post post)
	{
		CustomDbContext dbContext = new();
		PostsRepository postsRepository = new(dbContext);

		postsRepository.Add(post);

		await dbContext.SaveChangesAsync();
	}
}

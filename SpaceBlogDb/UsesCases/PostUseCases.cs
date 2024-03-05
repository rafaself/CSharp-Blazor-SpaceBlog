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

	public static async Task<IList<Post>> List()
	{
		var dbContext = new CustomDbContext();
		PostsRepository postsRepository = new(dbContext);

		var allPosts = await postsRepository.List();

		return allPosts;
	}
}

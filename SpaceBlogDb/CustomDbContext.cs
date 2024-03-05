using Microsoft.EntityFrameworkCore;
using SpaceBlogDb.Models;

namespace SpaceBlogDb;

public class CustomDbContext : DbContext
{
	
	public DbSet<Post> Posts { get; set; }

	public CustomDbContext()
	{

	}
	
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		string connectionString = "User ID=root;Password=rafa123;Host=localhost;Port=5432;Database=spaceblogdb;";

		optionsBuilder
			.UseNpgsql(connectionString);
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
	}

}

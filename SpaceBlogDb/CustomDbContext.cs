using Microsoft.EntityFrameworkCore;

namespace SpaceBlogDb;

public class CustomDbContext : DbContext
{
	
	public CustomDbContext()
	{

	}
	
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		base.OnConfiguring(optionsBuilder);
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
	}

}

using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
	public class MySqlContext : DbContext
	{
        public MySqlContext() {}
        public MySqlContext(DbContextOptions<MySqlContext> options) : base (options) { }

		public DbSet<Product> Products { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>().HasData(new Product 
			{ 
				Id = 2,
				Name = "Name",
				Price = 69.9M,
				Description = "Description",
				CategoryName = "CategoryName",
				ImageUrl = null
			});


			base.OnModelCreating(modelBuilder);
		}
	}
}

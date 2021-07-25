using Bite_IT.Domain;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace Bite_IT.Data
{
    public class RestaurantDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductInStock> ProductsInStock { get; set; }
        public DbSet<ProductItem> ProductItems { get; set; }
        public DbSet<Restaurant> Restaurant { get; set; }
        public DbSet<Stock> Stocks { get; set; }

        public RestaurantDbContext(DbContextOptions options) : base(options)
        {
            // EnumsMapper();
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=Bite_IT;User Id=postgres;Password=;");

        private void EnumsMapper ()
        {
            NpgsqlConnection.GlobalTypeMapper.MapEnum<MealType>();
            NpgsqlConnection.GlobalTypeMapper.MapEnum<ProductName>();
            NpgsqlConnection.GlobalTypeMapper.MapEnum<ProductType>();
            NpgsqlConnection.GlobalTypeMapper.MapEnum<PromotionType>();
            NpgsqlConnection.GlobalTypeMapper.MapEnum<Status>();
            //NpgsqlConnection.GlobalTypeMapper.MapEnum<TableNumber>();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductInStock>()
                .HasMany(pis => pis.ProductItems)
                .WithOne(pi => pi.ProductInStock)
                .HasForeignKey(pi => pi.ProductInStockId);
            modelBuilder.Entity<Meal>()
                .HasMany(meal => meal.Ingredients)
                .WithMany(ingr => ingr.Meals)
                .UsingEntity(j => j.ToTable("MealsIngredients"));
            modelBuilder.Entity<Menu>()
                .HasMany(menu => menu.Meals)
                .WithOne(meal => meal.Menu)
                .HasForeignKey(meal => meal.MenuId);
            modelBuilder.Entity<Order>()
                .HasMany(order => order.Meals)
                .WithMany(meal => meal.Orders)
                .UsingEntity(j => j.ToTable("OrdersMeals"));
            modelBuilder.Entity<Stock>()
                .HasMany(stock => stock.Products)
                .WithOne(product => product.Stock)
                .HasForeignKey(product => product.StockId);
            modelBuilder.Entity<Restaurant>()
                .HasMany(r => r.Stocks)
                .WithOne(stock => stock.Restaurant)
                .HasForeignKey(stock => stock.RestaurantId);
            modelBuilder.Entity<Restaurant>()
                .HasMany(restaurant => restaurant.Orders)
                .WithOne(order => order.Restaurant)
                .HasForeignKey(order => order.RestaurantId);
            modelBuilder.Entity<Restaurant>()
                .HasOne(restaurant => restaurant.Menu)
                .WithOne(menu => menu.Restaurant)
                .HasForeignKey<Menu>(menu => menu.RestaurantId);
            modelBuilder.Entity<Restaurant>()
                .HasMany(restaurant => restaurant.Employees)
                .WithOne(employee => employee.Restaurant)
                .HasForeignKey(employee => employee.RestaurantId);

            // modelBuilder.HasPostgresEnum<MealType>();
            // modelBuilder.HasPostgresEnum<ProductName>();
            // modelBuilder.HasPostgresEnum<ProductType>();
            // modelBuilder.HasPostgresEnum<PromotionType>();
            // modelBuilder.HasPostgresEnum<Status>();
            //modelBuilder.HasPostgresEnum<TableNumber>();
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
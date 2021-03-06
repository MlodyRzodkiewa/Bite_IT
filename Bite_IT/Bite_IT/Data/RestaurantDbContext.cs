using System;
using System.Collections.Generic;
using Bite_IT.Configurations.Entities;
using Bite_IT.Domain;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System.Configuration;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.IdentityModel.Protocols;

namespace Bite_IT.Data
{
    public class RestaurantDbContext : IdentityDbContext
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
        public DbSet<MealsIngredient> MealsIngredients { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        
        public RestaurantDbContext(DbContextOptions options) : base(options)
        {
            EnumsMapper();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql();
        
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
            // var converter = new ValueConverter<IList<MealType>, string>(
            //     v => v.ToString(),
            //     v => ())
            
            modelBuilder.Entity<ProductInStock>()
                .HasMany(pis => pis.ProductItems)
                .WithOne(pi => pi.ProductInStock)
                .HasForeignKey(pi => pi.ProductInStockId);
            modelBuilder.Entity<Meal>()
                .Property(meal => meal.FilterMarkers)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, null),
                    //v => JsonSerializer.Deserialize<List<MealType>>(v, null),
                    v => JsonSerializer.Deserialize<List<string>>(v, null),
                    new ValueComparer<ICollection<string>>(
                        (c1, c2) => c1.SequenceEqual(c2),
                        c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                        c => (ICollection<string>)c.ToList()));
            // modelBuilder.Entity<Meal>()
            //     .HasMany(meal => meal.Ingredients)
            //     .WithMany(ingr => ingr.Meals)
            //     .UsingEntity(j => j.ToTable("MealsIngredients"));
            modelBuilder.Entity<MealsIngredient>()
                .HasKey(mi => new { mi.IngredientId, mi.MealId });
            modelBuilder.Entity<MealsIngredient>()
                .HasOne(mi => mi.Meal)
                .WithMany(ingr => ingr.MealsIngredients)
                .HasForeignKey(mi => mi.MealId);
            modelBuilder.Entity<MealsIngredient>()
                .HasOne(mi => mi.Ingredient)
                .WithMany(ingr => ingr.MealsIngredients)
                .HasForeignKey(mi => mi.IngredientId);
            modelBuilder.Entity<Menu>()
                .HasMany(menu => menu.Meals)
                .WithOne(meal => meal.Menu)
                .HasForeignKey(meal => meal.MenuId);
            /*modelBuilder.Entity<Order>()
                .HasMany(order => order.Meal)
                .WithMany(meal => meal.Orders)
                .UsingEntity(j => j.ToTable("OrdersLines"));*/
            
            //modelBuilder.Entity<OrderLine>()
            //    .HasKey(ol => new { ol.OrderId, ol.MealId });  
            modelBuilder.Entity<OrderLine>()
                .HasOne(ol => ol.Order)
                .WithMany(or => or.OrderLines)
                .HasForeignKey(ol => ol.OrderId);  
            modelBuilder.Entity<OrderLine>()
                .HasOne(ol => ol.Meal)
                .WithMany(me => me.OrderLines)
                .HasForeignKey(ol => ol.MealId);
            
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

            modelBuilder.HasPostgresEnum<MealType>();
            modelBuilder.HasPostgresEnum<ProductName>();
            modelBuilder.HasPostgresEnum<ProductType>();
            modelBuilder.HasPostgresEnum<PromotionType>();
            modelBuilder.HasPostgresEnum<Status>();
            //modelBuilder.HasPostgresEnum<TableNumber>();
            
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new StockConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new IngredientConfiguration());
            modelBuilder.ApplyConfiguration(new MealsIngredientsConfiguration());
            modelBuilder.ApplyConfiguration(new MealConfiguration());
            modelBuilder.ApplyConfiguration(new MenuConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new ProductItemConfiguration());
            modelBuilder.ApplyConfiguration(new ProductInStockConfiguration());
            modelBuilder.ApplyConfiguration(new RestaurantConfiguration());
            
        }
    }
}
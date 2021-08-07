using System;
using System.Threading.Tasks;
using Bite_IT.Data;
using Bite_IT.Domain;

namespace Bite_IT.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RestaurantDbContext _context;

        public UnitOfWork(RestaurantDbContext context)
        {
            this._context = context;
        }

        public IGenericRepository<Employee> Employees => new GenericRepository<Employee>(_context);
        public IGenericRepository<Ingredient> Ingredients => new GenericRepository<Ingredient>(_context);
        public IGenericRepository<Meal> Meals => new GenericRepository<Meal>(_context);
        public IGenericRepository<MealsIngredient> MealsIngredients => new GenericRepository<MealsIngredient>(_context);
        public IGenericRepository<Menu> Menu => new GenericRepository<Menu>(_context);
        public IGenericRepository<Order> Orders => new GenericRepository<Order>(_context);
        public IGenericRepository<ProductInStock> ProductsInStock => new GenericRepository<ProductInStock>(_context);
        public IGenericRepository<ProductItem> ProductItems => new GenericRepository<ProductItem>(_context);
        public IGenericRepository<Restaurant> Restaurants => new GenericRepository<Restaurant>(_context);
        public IGenericRepository<Stock> Stock => new GenericRepository<Stock>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(true);
        }
        
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
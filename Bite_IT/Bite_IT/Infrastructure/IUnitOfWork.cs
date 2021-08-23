using System;
using System.Threading.Tasks;
using Bite_IT.Domain;

namespace Bite_IT.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Employee> Employees { get; }
        IGenericRepository<Ingredient> Ingredients { get; }
        IGenericRepository<Meal> Meals { get; }
        IGenericRepository<MealsIngredient> MealsIngredients { get; }
        IGenericRepository<Menu> Menu { get; }
        IGenericRepository<Order> Orders { get; }
        IGenericRepository<ProductInStock> ProductsInStock { get; }
        IGenericRepository<ProductItem> ProductItems { get; }
        IGenericRepository<Restaurant> Restaurants { get; }
        IGenericRepository<Stock> Stock { get; }
        IGenericRepository<OrderLine> OrderLines { get; }
        Task Save();
    }
}
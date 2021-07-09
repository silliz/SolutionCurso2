using System.Threading.Tasks;
using Baskket.API.Entities;

namespace Baskket.API.Repositories
{
    public interface IBasketRepository
    {
        
        Task<ShoppingCart> GetBasket(string userName);
        Task<ShoppingCart> UpdateBasket(ShoppingCart basket);
        Task DeleteBasket(string userName);
    }
}
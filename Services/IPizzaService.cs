using BlazingPizza.Models;

namespace BlazingPizza.Services
{
    public interface IPizzaService
    {
        Task<List<Pizza>> GetAllPizzasAsync();
    }
}
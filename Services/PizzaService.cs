using BlazingPizza.Data;
using BlazingPizza.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Services
{
    public class PizzaService : IPizzaService
    {
        private readonly PizzaContext _context;

        public PizzaService(PizzaContext context)
        {
            _context = context;
        }

        public async Task<List<Pizza>> GetAllPizzasAsync()
        {
            var pizzaList = await _context.Pizzas.ToListAsync();
            return pizzaList;
        }
    }
}
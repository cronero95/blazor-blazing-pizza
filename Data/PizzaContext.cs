using BlazingPizza.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Data
{
    public class PizzaContext : DbContext
    {
        public PizzaContext(DbContextOptions<PizzaContext> options) : base(options) {}

        public DbSet<Pizza> Pizzas { get; set; } = default!;
    }
}
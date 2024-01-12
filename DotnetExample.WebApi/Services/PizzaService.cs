using DotnetExample.WebApi.Models;

namespace DotnetExample.WebApi.Services;

public static class PizzaService {
    static List<PizzaService> Pizzas { get; }
    static int nextId = 3;
    static PizzaService() {
        Pizzas = new List<PizzaService> {
            new PizzaService { Id = 1, Name = "Classic Italian", IsGlutenFree = false},
            new PizzaService { Id = 2, Name = "Veggie", IsGlutenFree = true}
        };
    }

    public static List<Pizza> GetAll() => Pizzas;

    public static Pizza? Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);

    public static void Add(Pizza pizza) {
        pizza.Id = nextId++;
        Pizzas.Add(pizza);
    }

    public static void Delete(int id) {
        var pizza = Get(id);
        if (pizza is null)
            return;
        Pizzas.Remove(pizza);
    }

    public static void Update(Pizza pizza) {
        var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
        if (index == -1) {
            return;
        }

        Pizzas[index] = pizza;
    }
}
using CookingAssistant.Handlers.Interfaces;
using CookingAssistant.Models;
using Grpc.Core;

namespace CookingAssistant.Handlers.Implementations;

public class CookerHandler : ICookerHandler<Recipe, Ingredient>
{
    public async Task<IEnumerable<Recipe>> GetAllRecipes()
    {
        var recipes = FetchRecipes();

        return await Task.FromResult(recipes);
    }

    public async Task<Recipe> GetRecipeDetail(string recipeCode)
    {
        var recipes = FetchRecipes();

        var recipeDetail = recipes.FirstOrDefault(r => r.Code == recipeCode);

        if (recipeDetail == null)
            throw new RpcException(new Status(StatusCode.NotFound, "Recipe not found"));
        else
            return await Task.FromResult(recipeDetail);
    }

    public Task<IEnumerable<Recipe>> GetRecipesForIngredients(string[] ingredients,
        bool includeRecipesWithMissingIngredients)
    {
        var receitas = FetchRecipes();

        if (includeRecipesWithMissingIngredients)
        {
            return Task.FromResult(receitas.Where(x => x.MightBeCooked(ingredients)));
        }
        else
        {
            return Task.FromResult(receitas.Where(x => x.CanBeCooked(ingredients)));
        }
    }

    private List<Recipe> FetchRecipes()
    {
        var recipes = new List<Recipe>();
        // Bacalhau à Brás
        var bacalhauABras = new Recipe("BB001", "Bacalhau à Brás", "Receita milenar de bacalhau");
        bacalhauABras.AddIngredient(new Ingredient("BAC001", "500 g"));
        bacalhauABras.AddIngredient(new Ingredient("BTP002", "300 g"));
        bacalhauABras.AddIngredient(new Ingredient("EGG003", "6 unidades"));
        bacalhauABras.AddIngredient(new Ingredient("ONI004", "1 grande"));
        bacalhauABras.AddIngredient(new Ingredient("GAR005", "2 dentes"));
        bacalhauABras.AddIngredient(new Ingredient("OIL006", "q.b."));
        bacalhauABras.AddIngredient(new Ingredient("PAR007", "q.b."));
        bacalhauABras.AddIngredient(new Ingredient("OLV008", "q.b."));
        recipes.Add(bacalhauABras);

        var cozidoAPortuguesa = new Recipe("CP001", "Cozido à Portuguesa",
            "Receita milenar de cozido, a receita mais portuguesa");
        cozidoAPortuguesa.AddIngredient(new Ingredient("BEE009", "500 g"));
        cozidoAPortuguesa.AddIngredient(new Ingredient("PIG010", "500 g"));
        cozidoAPortuguesa.AddIngredient(new Ingredient("CHR011", "1 unidade"));
        cozidoAPortuguesa.AddIngredient(new Ingredient("POT012", "6 unidades"));
        cozidoAPortuguesa.AddIngredient(new Ingredient("CAR013", "3 unidades"));
        cozidoAPortuguesa.AddIngredient(new Ingredient("CAB014", "1 unidade"));
        cozidoAPortuguesa.AddIngredient(new Ingredient("BWN015", "500 g"));
        recipes.Add(cozidoAPortuguesa);

        return recipes;
    }
}
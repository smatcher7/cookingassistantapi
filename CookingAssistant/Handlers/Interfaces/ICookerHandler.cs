namespace CookingAssistant.Handlers.Interfaces;

public interface ICookerHandler<TRecipe, TIngredient>
{
    public Task<IEnumerable<TRecipe>> GetAllRecipes();
    
    public Task<TRecipe> GetRecipeDetail(string recipeCode);

    public Task<IEnumerable<TRecipe>> GetRecipesForIngredients(string[] ingredients, bool includeRecipesWithMissingIngredients);
}
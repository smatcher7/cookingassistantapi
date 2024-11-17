namespace CookingAssistant.Models;

public class Recipe
{
    public Recipe(string code, string name, string description)
    {
        Code = code;
        Name = name;
        Description = description;
    }

    public string Code { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    private IEnumerable<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

    public void AddIngredient(Ingredient ingredient)
    {
        Ingredients = Ingredients.Append(ingredient);
    }

    public bool CanBeCooked(string[] ingredients)
    {
        return this.Ingredients.All(x => ingredients.Contains(x.Code));
    }

    public bool MightBeCooked(string[] ingredients)
    {
        return this.Ingredients.Any(x => ingredients.Contains(x.Code));
    }
    
    public IEnumerable<Ingredient> GetIngredients() => Ingredients;
}
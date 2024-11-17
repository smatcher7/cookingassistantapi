namespace CookingAssistant.Models;

public class Ingredient
{
    public string Code { get; set; }
    public string Quantity { get; set; }

    public Ingredient(string ingredientCode, string quantity)
    {
        Code = ingredientCode;
        Quantity = quantity;
    }
}
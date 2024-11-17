using CookingAssistant.Handlers.Interfaces;
using CookingAssistant.Models;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace CookingAssistant.Services.Protobuf;

public class CookerService(ICookerHandler<Recipe, Ingredient> cookerHandler) : Cooker.CookerBase
{
    private readonly ICookerHandler<Recipe, Ingredient> _cookerHandler = cookerHandler;

    public override async Task<GetAllRecipesReply> GetAllRecipes(Empty request, ServerCallContext context)
    {
        var allRecipes = await _cookerHandler.GetAllRecipes();

        var reply = new GetAllRecipesReply();

        reply.Recipes.AddRange(allRecipes.Select(x => new GetAllRecipesReply.Types.recipe()
        {
            Code = x.Code,
            Description = x.Description,
            Name = x.Name
        }));

        return reply;
    }

    public override async Task<GetRecipeDetailReply> GetRecipeDetail(GetRecipeDetailRequest request, ServerCallContext context)
    {
        var recipeDetail = await _cookerHandler.GetRecipeDetail(request.Code);

        var reply = new GetRecipeDetailReply
        {
            Code = recipeDetail.Code,
            Description = recipeDetail.Description,
            Name = recipeDetail.Name
        };

        reply.Ingredients.AddRange(recipeDetail.GetIngredients().Select(i => new GetRecipeDetailReply.Types.ingredient
        {
            Code = i.Code,
            Name = i.Code,
            Quantity = i.Quantity
        }));

        return reply;
    }

    public override async Task<GetRecipesForIngredientsReply> GetRecipesForIngredients(GetRecipesForIngredientsRequest request, ServerCallContext context)
    {
        var recipes = await _cookerHandler.GetRecipesForIngredients(request.Ingredients.ToArray(), request.IncludeRecipesWithMissingIngredients);

        GetRecipesForIngredientsReply reply = new GetRecipesForIngredientsReply();

        reply.Recipes.AddRange(recipes.Select(r => new GetRecipesForIngredientsReply.Types.recipe
        {
            Code = r.Code,
            Description = r.Description,
            Name = r.Name
        }));

        return reply;
    }
}
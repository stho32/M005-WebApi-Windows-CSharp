using System.Text.Json;
using Provisioning.Interfaces;
using Provisioning.Interfaces.Recipes.List;
using Provisioning.Interfaces.RecipeStructure;

namespace Provisioning.Infrastructure;
public class WebBasedRecipeRepository : IRecipeRepository
{
    private readonly string _baseUrl;

    public WebBasedRecipeRepository(string baseUrl)
    {
        _baseUrl = baseUrl;
    }
    
    public async Task<Recipe> GetByFilePath(string filePath)
    {
        using var httpClient = new HttpClient();

        try
        {
            var jsonString = await httpClient.GetStringAsync(_baseUrl + "/" + filePath);
            var recipe = JsonSerializer.Deserialize<Recipe>(jsonString, new JsonSerializerOptions {
                PropertyNameCaseInsensitive = true
            }); 
            return recipe;
        }
        catch (HttpRequestException)
        {
            // We actually do not care much about the type of error. 
            // Network or file not found is the same to us.
        }

        return null;
    }

    public async Task<RecipeSummary[]?> GetList()
    {
        using var httpClient = new HttpClient();
        
        var jsonString = await httpClient.GetStringAsync(_baseUrl + "/RecipeList.json");
        var recipes = JsonSerializer.Deserialize<RecipeSummary[]>(jsonString, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        }); 
        
        return recipes;
    }
}

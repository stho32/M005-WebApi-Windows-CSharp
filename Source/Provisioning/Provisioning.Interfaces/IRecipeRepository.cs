using Provisioning.Interfaces.Recipes.List;
using Provisioning.Interfaces.RecipeStructure;

namespace Provisioning.Interfaces;
public interface IRecipeRepository
{
    Task<RecipeSummary[]?> GetList();
    Task<Recipe> GetByFilePath(string filePath);
}





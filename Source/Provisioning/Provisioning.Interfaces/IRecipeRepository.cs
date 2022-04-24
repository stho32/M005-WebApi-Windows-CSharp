using Provisioning.Interfaces.RecipeStructure;

namespace Provisioning.Interfaces;
public interface IRecipeRepository
{
    Recipe[] GetList();
}



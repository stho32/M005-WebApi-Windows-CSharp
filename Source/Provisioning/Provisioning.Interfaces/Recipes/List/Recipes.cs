namespace Provisioning.Interfaces.Recipes.List;

public class Recipes
{
    public RecipeSummary[] RecipeSummaries { get; }

    public Recipes()
    {
    }

    public Recipes(RecipeSummary[] recipeSummaries)
    {
        RecipeSummaries = recipeSummaries;
    }
}
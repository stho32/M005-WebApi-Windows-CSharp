namespace Provisioning.Interfaces.Recipes.List;

public class Recipes
{
    public RecipeSummary[]? RecipeSummaries { get; set; }

    public Recipes()
    {
        RecipeSummaries = Array.Empty<RecipeSummary>();
    }

    public Recipes(RecipeSummary[]? recipeSummaries)
    {
        RecipeSummaries = recipeSummaries;
    }
}
namespace Provisioning.Interfaces.Recipes.List;

public class RecipeSummary
{
    public string Name { get; }
    public string Description { get; }
    public string FilePath { get; }

    public RecipeSummary()
    {
    }

    public RecipeSummary(string name, string description, string filePath)
    {
        Name = name;
        Description = description;
        FilePath = filePath;
    }
}
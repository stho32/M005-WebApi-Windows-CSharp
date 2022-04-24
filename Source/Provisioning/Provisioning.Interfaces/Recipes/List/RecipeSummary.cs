namespace Provisioning.Interfaces.Recipes.List;

public class RecipeSummary
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string FilePath { get; set; }

    public RecipeSummary()
    {
        Name = "";
        Description = "";
        FilePath = "";
    }

    public RecipeSummary(string name, string description, string filePath)
    {
        Name = name;
        Description = description;
        FilePath = filePath;
    }
}
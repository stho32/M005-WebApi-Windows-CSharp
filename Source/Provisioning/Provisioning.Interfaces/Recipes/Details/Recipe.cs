namespace Provisioning.Interfaces.RecipeStructure;

public class Recipe
{
    public string Name { get; set; }
    public HostDescription[] HostDescriptions { get; set; }

    public Recipe()
    {
        Name = "";
        HostDescriptions = Array.Empty<HostDescription>();
    }
    
    public Recipe(string name, HostDescription[] hostDescriptions)
    {
        Name = name;
        HostDescriptions = hostDescriptions;
    }
}
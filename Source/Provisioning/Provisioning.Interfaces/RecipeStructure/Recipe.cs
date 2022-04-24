namespace Provisioning.Interfaces.RecipeStructure;

public class Recipe
{
    public string Name { get; }
    public HostDescription[] HostDescriptions { get; }

    public Recipe()
    {
    }
    
    public Recipe(string name, HostDescription[] hostDescriptions)
    {
        Name = name;
        HostDescriptions = hostDescriptions;
    }
}
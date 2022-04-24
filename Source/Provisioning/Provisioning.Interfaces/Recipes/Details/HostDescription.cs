namespace Provisioning.Interfaces.RecipeStructure;

public class HostDescription
{
    public string Name { get; }
    public string Description { get; }
    public Task[] Tasks { get; }

    public HostDescription()
    {
    }
    
    public HostDescription(string name, string description, Task[] tasks)
    {
        Name = name;
        Description = description;
        Tasks = tasks;
    }
}
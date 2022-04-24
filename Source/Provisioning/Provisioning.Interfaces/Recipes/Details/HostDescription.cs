namespace Provisioning.Interfaces.RecipeStructure;

public class HostDescription
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Task[] Tasks { get; set; }

    public HostDescription()
    {
        Name = "";
        Description = "";
        Tasks = Array.Empty<Task>();
    }
    
    public HostDescription(string name, string description, Task[] tasks)
    {
        Name = name;
        Description = description;
        Tasks = tasks;
    }
}
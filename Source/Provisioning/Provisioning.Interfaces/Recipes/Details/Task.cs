namespace Provisioning.Interfaces.RecipeStructure;

public class Task
{
    public string Name { get; }
    public bool AsAdmin { get; }
    public string Shell { get; }
    public string Command { get; }

    public Task()
    {
    }
    
    public Task(string name, bool asAdmin, string shell, string command)
    {
        Name = name;
        AsAdmin = asAdmin;
        Shell = shell;
        Command = command;
    }
}
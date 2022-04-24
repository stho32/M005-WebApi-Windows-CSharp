namespace Provisioning.Interfaces.RecipeStructure;

public class Task
{
    public string Name { get; set; }
    public bool AsAdmin { get; set; }
    public string Shell { get; set; }
    public string Command { get; set; }

    public Task()
    {
        Name = "";
        AsAdmin = false;
        Shell = "";
        Command = "";
    }
    
    public Task(string name, bool asAdmin, string shell, string command)
    {
        Name = name;
        AsAdmin = asAdmin;
        Shell = shell;
        Command = command;
    }
}
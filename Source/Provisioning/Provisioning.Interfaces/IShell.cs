namespace Provisioning.Interfaces;

public interface IShell
{
    bool IsResponsibleFor(Task task);
    ITaskResult Execute(Task task);
}
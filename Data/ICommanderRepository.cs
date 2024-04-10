using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepository
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommand(int  id);

    }
}

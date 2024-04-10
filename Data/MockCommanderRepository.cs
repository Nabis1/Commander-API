using Commander.Models;
using Microsoft.Extensions.Hosting;

namespace Commander.Data
{
    public class MockCommanderRepository : ICommanderRepository
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id = 0, HowTo = "Boil an egg", Line = "Boil Water", Platform = "Kettle & Pan" },
                new Command{Id = 1, HowTo = "Boil an water", Line = "Boil Water", Platform = "Kettle & Pan"},
                new Command{Id = 2, HowTo = "Boil an oil", Line = "Boil Water", Platform = "Kettle & Pan"}
            };
            return commands;
        }

        public Command GetCommand(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil Water", Platform = "Kettle & Pan" };
        }

        internal object GetCommandByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}

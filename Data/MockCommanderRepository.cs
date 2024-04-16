using Commander.Models;
using Microsoft.Extensions.Hosting;

namespace Commander.Data
{
    public class MockCommanderRepository : ICommanderRepository
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id = 0, HowTo = "Boil an egg", Line = "Boil Water", Platform = "Kettle & Pan" },
                new Command{Id = 1, HowTo = "Cut a bread", Line = "Knife", Platform = "Kettle & Pan"},
                new Command{Id = 2, HowTo = "Boil an oil", Line = "Boil Water", Platform = "Kettle & Pan"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil Water", Platform = "Kettle & Pan" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}

using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    // creates class to implement interface
    public class MockCommanderRepo : ICommanderRepo 
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
           var commands = new List<Command>
           { // default list to return 
                new Command{Id=0, HowTo="one", Line="Boil water", Platform="Kettle"}, 
                new Command{Id=1, HowTo="two", Line="Boil water", Platform="Kettle"}, 
                new Command{Id=2, HowTo="three ", Line="Boil", Platform="Kettle"}, 
           };

           return commands; // this is a mock repository with fake data that doesn't really do anything
        

        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=id, HowTo="Boil an Egg", Line="Boil water", Platform="Kettle"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            // we do nothing here for now 
        }
    }
}
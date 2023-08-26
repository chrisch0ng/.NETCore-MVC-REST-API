using System.Collections.Generic; 
using Commander.Models;


namespace Commander.Data 
{
    public interface ICommanderRepo // list of method signatures to provide to interface user 
    { // since this is a rest api which does create delete operations, we just do CRUD operations
    // starting with reading 
        // give list of all command objects 

        bool SaveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id) ; 
        //where we start to add new contract items to create new things in the database

        void CreateCommand(Command cmd);

        void UpdateCommand(Command cmd);

        void DeleteCommand(Command cmd);

    }

}
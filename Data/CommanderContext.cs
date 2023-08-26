using Commander.Models;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data 
{
    public class CommanderContext : DbContext // inherits from relevant namespace 
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {
            
        }

        public DbSet<Command> Commands { get; set; } // representing command database as DbSet called Commands 
        
    }
}
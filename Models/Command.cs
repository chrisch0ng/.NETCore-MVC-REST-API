using System.ComponentModel.DataAnnotations;

namespace Commander.Models 
{
    public class Command
    { // defining properties for command 
        [Key]
        public int Id {get; set; }
        
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; } // command line snipet to store on database

        [Required]
        public string Platform { get; set; }

    }
}
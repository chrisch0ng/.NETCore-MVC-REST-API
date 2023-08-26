using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class CommandUpdateDto
    { // defining properties for command 
        
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }

        [Required] // this is so that if a command that doesn't have the required fields gets passed, we will know that 
        // it wasn't a server side error by a client side error becuase they gave a request that doesn't have the required fields 
        public string Line { get; set; } // command line snipet to store on database

        [Required]
        public string Platform { get; set; }


    }
}
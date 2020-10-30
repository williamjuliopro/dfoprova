using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi
{
    [Table("User")]
    public class User
    {       
        public User()
        {            
        }

        [Key]
        [Column("Id")]
        public int id { get; set; }
        
        [Column("Name")]
        [StringLength(50, MinimumLength = 0)]
        public string Name { get; set; }
        
        [Column("Age")]
        public int Age { get; set; }

        [Column("Address")]
        [StringLength(50, MinimumLength = 0)]
        public string Address { get; set; }        

    }
}

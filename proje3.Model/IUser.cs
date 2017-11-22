using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje3.Model
{

    [Table("User")]
public abstract class IUser : Entity<long>
    {
    //    [Key]
        
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
    }
}

using SFDEnerji.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFDEnerji.Models.Concrete
{
    [Table("Users")]
    public class AppUser :BaseModel
    {

        public string Password  { get; set; }
    }
}

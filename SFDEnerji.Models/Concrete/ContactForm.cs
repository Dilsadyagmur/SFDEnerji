using SFDEnerji.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFDEnerji.Models.Concrete
{
    [Table("ContactForms")]
    public class ContactForm : BaseModel
    {
        public string Email { get; set; }
        public string? Phone { get; set; }
        public string? Subject { get; set; }
        public string  Message { get; set; }
    }
}

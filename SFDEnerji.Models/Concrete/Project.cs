using SFDEnerji.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SFDEnerji.Models.Concrete
{
    public class Project : BaseModel
    {
        public string  Content { get; set; }
        public string  Slug { get; set; }
        public string?  Thumbnail { get; set; }
        public int ViewCount { get; set; }
        public virtual ICollection<Picture>? Pictures { get; set; } = new List<Picture>();
    }
}

using SFDEnerji.Models.Concrete;
using SFDEnerji.Repository.Shared.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFDEnerji.Repository.Shared.Abstract
{
    public interface IUnitOfWork 
    {
        IRepository<AppUser> Users { get; }

        IRepository<Meta> Metas { get; }

        IRepository<Page> Pages   { get; }

        IRepository<Service> Services   { get; }

        IRepository<ContactForm> ContactForms   { get; }

        IRepository<Picture> Pictures   { get; }

        IRepository<Project> Projects   { get; }


        void Save();

}
}

﻿using Microsoft.EntityFrameworkCore;
using SFDEnerji.Models.Concrete;

namespace SFDEnerji.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
            
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public virtual DbSet<AppUser> Users { get; set; }
        public virtual DbSet<ContactForm> ContactForms { get; set; }
        public virtual DbSet<Meta> Metas { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Service> Services { get; set; }
    }
}
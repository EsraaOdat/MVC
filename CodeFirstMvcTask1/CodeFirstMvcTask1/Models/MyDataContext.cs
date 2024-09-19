using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;

namespace CodeFirstMvcTask1.Models
{
    public class MyDataContext : DbContext
    {
        public MyDataContext() : base("Esraa")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Assigment> Assigments { get; set; }
        public DbSet<StudentDetails> StudentDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student>()
                .HasOptional(p => p.Details)
                .WithRequired(a => a.Student);

            modelBuilder.Entity<Teacher>()
                .HasOptional(a => a.Classes)
                .WithRequired(v => v.Teacher);

            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<CodeFirstMvcTask1.Models.Classes> Classes { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BPT.Test.JASM.BackEnd.DataAccess
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }

        protected DBContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudenAssigments>().HasKey(a => new { a.IdAssignments, a.IdStudent });
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Assignments> Assignments { get; set; }

        public DbSet<StudenAssigments> StudenAssigments { get; set; }

    }
}

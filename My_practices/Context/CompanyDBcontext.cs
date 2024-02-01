using Microsoft.EntityFrameworkCore;
using My_practices.Entrities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_practices.Context
{
    internal class CompanyDBcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = Ahmed; Database = company__db ; Trusted_Connection = True ; TrustServerCertificate=true ;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employees");
            modelBuilder.Entity<Employee>().HasKey(d => d.Id);
            // modelBuilder.Entity<Employee>().HasKey(nameof(Department.Id));
            modelBuilder.Entity<Employee>()
                .Property(d => d.Id)
                .UseIdentityColumn(10, 3);
            modelBuilder.Entity<Employee>()
               .Property(D => D.Name).HasMaxLength(90).
               IsRequired(true).
               HasDefaultValue("mkj");
            modelBuilder.Entity<Employee>().Property(D => D.Age)
              .IsRequired(true)
              .HasColumnType("varchar");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Department { get; set; }

    }
}

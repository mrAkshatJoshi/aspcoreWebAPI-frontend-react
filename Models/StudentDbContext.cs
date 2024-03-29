﻿using Microsoft.EntityFrameworkCore;

namespace ReactAspCrud.Models
{
    public class StudentDbContext : DbContext//using Microsoft.EntityFrameworkCore;
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =DESKTOP-49ELLTT\\sa; Initial Catalog = lbs; User Id=sa;password = 123;TrustServerCertificate=True");
        }
    }
}

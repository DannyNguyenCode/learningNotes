//dotnet add package Microsoft.EntityFrameworkcore
//dotnet add package CsvHelper --version 27.0.2

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace Projects.Models
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options){

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Technology>().HasMany(t => t.Sectors);
            modelBuilder.Entity<Sector>().HasOne(s => s.Technologies);
            modelBuilder.Seed();
        }
        public DbSet<Technology> Technologies {get;set;}
        public DbSet<Sector> Sectors {get;set;}
    }
}
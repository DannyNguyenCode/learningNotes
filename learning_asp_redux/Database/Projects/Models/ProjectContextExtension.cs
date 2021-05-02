using CsvHelper;
using System.IO;
using System.Reflection;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;

namespace Projects.Models
{
    public static class ProjectContextExtension
    {
        public static void Seed(this ModelBuilder context)
        {
            context.Entity<Technology>().HasData(
                new Technology {Id= 1, Name="Bitcoin"},
                new Technology {Id=2, Name="Ethereum"}
            );
            context.Entity<Sector>().HasData(
                new Sector {Id=1, Name="Uniswap", Description="Decentralized Exchange"},
                new Sector {Id=2, Name="Polygon", Description="Side Chain"}

            );

        }
    }
}
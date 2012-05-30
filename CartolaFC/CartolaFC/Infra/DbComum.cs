using System.Data.Entity;
using CartolaFC.Models;

namespace CartolaFC.Infra
{
    public class DbComum : DbContext
    {
        public DbComum():base("CartolaFC")
        {
            
        }

        public DbSet<Time> Times { get; set; }
        public DbSet<Tecnico> Tecnicos { get; set; } 
    }
}
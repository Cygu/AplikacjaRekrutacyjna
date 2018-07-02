using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;

namespace WebApplication1.Model
{
    public class ApkaContext : DbContext
    {
        public DbSet<TowarEntity> Towary { get; set; }
        public DbSet<SklepEntity> Sklepy { get; set; }
        public DbSet<DostawcaEntity> Dostawcy { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Database=bazaProjekt;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");        }
    }
}

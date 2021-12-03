using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDiagnoses
{
    public class DiagnoseContext : DbContext
    {
        public DbSet<Diagnose> Diagnoses { get; set; }

        public DiagnoseContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Only needed for console usage. In ASP.NET Core please use the DI-option.
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Stamdata;Trusted_Connection=True;");
        }
    }
}

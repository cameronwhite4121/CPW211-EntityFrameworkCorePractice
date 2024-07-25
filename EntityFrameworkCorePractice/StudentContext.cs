using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCorePractice
{
    /// <summary>
    /// Context is usually included as a suffix when making classes for
    /// databases.
    /// </summary>
    public class StudentContext : DbContext
    {
        public StudentContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Database = Name for the database
            // Server = Server we are connecting to 
            // Trusted connection = indicates the windows account will be used
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFCoreExample;Trusted_Connection=True;");
        }

        /// <summary>
        /// Tell ef core to track Students in the database
        /// </summary>
        public DbSet<Student> Students { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApp.EF
{
    public class RegistrationAppDbContextFactory : IDesignTimeDbContextFactory<RegistrationAppDbContext>
    {
        private readonly string ConnectionString = @"Server=(localDB)\MyTestLocalDB;Database=RegistrationAppDb;Trusted_Connection=True;";
        public RegistrationAppDbContext CreateDbContext(string[] args = null)
        {
            var optionsBuilder = new DbContextOptionsBuilder<RegistrationAppDbContext>();
            optionsBuilder.UseSqlServer(ConnectionString);

            return new RegistrationAppDbContext(optionsBuilder.Options);
        }
    }
}

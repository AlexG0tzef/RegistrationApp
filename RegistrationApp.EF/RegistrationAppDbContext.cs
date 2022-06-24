using Microsoft.EntityFrameworkCore;
using RegistrationApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegistrationApp.EF
{
    public class RegistrationAppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }

        public RegistrationAppDbContext(DbContextOptions contextOptions) : base(contextOptions) { }

    }
}

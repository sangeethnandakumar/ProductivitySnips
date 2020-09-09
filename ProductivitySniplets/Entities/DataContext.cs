using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class DataContext : DbContext
    {
        //Context Constructor
        public DataContext(DbContextOptions options) : base(options) {}

        //Tables
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}

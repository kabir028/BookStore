using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using onlinebook.Models;

namespace onlinebook.Data
{
    public class onlinebookContext : DbContext
    {
        public onlinebookContext (DbContextOptions<onlinebookContext> options)
            : base(options)
        {
        }

        public DbSet<onlinebook.Models.book> book { get; set; } = default!;

        public DbSet<onlinebook.Models.usersaccounts> usersaccounts { get; set; }

        public DbSet<onlinebook.Models.orders> orders { get; set; }
        public DbSet<onlinebook.Models.report> report { get; set; }

    }
}

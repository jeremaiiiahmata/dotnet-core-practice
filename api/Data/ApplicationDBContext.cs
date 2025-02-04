using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    // This class represents the application's database context, which is used to interact with the database.
    // It inherits from DbContext, which is the base class for working with Entity Framework Core.
    public class ApplicationDBContext : DbContext
    {
        // Constructor: Accepts DbContextOptions (which contain configuration settings like connection strings).
        // Calls the base class constructor (DbContext) to initialize the context.
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }

        // DbSet properties represent tables in the database. Entity Framework Core uses these properties
        // to map the database tables to C# objects.

        public DbSet<Stock> Stocks { get; set; } // Represents the "Stocks" table in the database.
        public DbSet<Comment> Comments { get; set; } // Represents the "Comments" table in the database.
    }
}
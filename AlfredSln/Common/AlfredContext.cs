using Common.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class AlfredContext : DbContext
    {
        public AlfredContext()
            : base("DefaultConnection")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<MifgaimContext, MifgaimCivilians.Migrations.Configuration>("DefaultConnection"));
        }

        public DbSet<User> MyUsers { get; set; }
        public DbSet<Expression> MyExpressions { get; set; }
        public DbSet<Movie> MyMovies { get; set; }
    }
}

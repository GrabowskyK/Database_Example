using Database_Example.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection.Emit;
using System.Threading;

namespace Database_Example.Database
{
        public class DatabaseContext : DbContext
        {
            public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
            {
            }
        DbSet<Users> User { get; set; }
        DbSet<FlashCards> FlashCards { get; set; }
        DbSet<Words> Word { get; set; }
    }
}

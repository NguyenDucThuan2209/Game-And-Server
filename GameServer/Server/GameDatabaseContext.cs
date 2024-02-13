using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SharedLibrary;

namespace Server
{
    public class GameDatabaseContext : DbContext
    {
        public DbSet<User> Users
        {
            get; set;
        } 

        public GameDatabaseContext(DbContextOptions<GameDatabaseContext> options) : base()
        {

        }
    }
}

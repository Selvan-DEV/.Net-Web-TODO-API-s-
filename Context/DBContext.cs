using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo_APP.Models;

namespace Todo_APP.Context
{
    public class DBContext: DbContext
    {
        public DBContext(DbContextOptions<DBContext> options): base(options)
        {

        }

        public DbSet<Tasks> ToDoTasks { get; set; }
        public DbSet<Workers> Workers { get; set; }
    }
}

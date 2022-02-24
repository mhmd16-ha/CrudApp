using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudApp.Models;

namespace CrudApp.Models
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> options) :base(options)
        {

        }
        public DbSet<CrudApp.Models.Students> Students { get; set; }

      

    }
}

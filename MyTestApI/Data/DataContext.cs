using Microsoft.EntityFrameworkCore;
using MyTestApI.Models;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace MyTestApI.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>opt):base(opt)
        {

        }

        public DbSet<Cars> CarsTable { get; set; }
    }
}

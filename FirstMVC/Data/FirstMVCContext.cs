using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FirstMVC.Models
{
    public class FirstMVCContext : DbContext
    {
        public FirstMVCContext (DbContextOptions<FirstMVCContext> options)
            : base(options)
        {
        }

        public DbSet<FirstMVC.Models.Movie> Movie { get; set; }
    }
}

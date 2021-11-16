using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASM.Models;

namespace ASM.Data
{
    public class ASMContext : DbContext
    {
        public ASMContext (DbContextOptions<ASMContext> options)
            : base(options)
        {
        }

        public DbSet<ASM.Models.Category> Category { get; set; }

        public DbSet<ASM.Models.Product> Product { get; set; }
    }
}

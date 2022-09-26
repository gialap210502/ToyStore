using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcToyStore.Models;

namespace MvcToyStore.Data
{
public class MvcToyContext : DbContext
    {
        public MvcToyContext (DbContextOptions<MvcToyContext> options)
            : base(options)
        {
        }

        public DbSet<MvcToyStore.Models.Toy> Toy { get; set; } = default!;
    }
}
    

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

    public class MvcToyContext : DbContext
    {
        public MvcToyContext (DbContextOptions<MvcToyContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Toy> Toy { get; set; } = default!;
    }

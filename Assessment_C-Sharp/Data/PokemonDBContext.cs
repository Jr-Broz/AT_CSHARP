using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assessment_C_Sharp.Models;

namespace Assessment_C_Sharp.Data
{
    public class PokemonDBContext : DbContext
    {
        public PokemonDBContext (DbContextOptions<PokemonDBContext> options)
            : base(options)
        {
        }

        public DbSet<Assessment_C_Sharp.Models.Pokemon> Pokemon { get; set; } = default!;

        public DbSet<Assessment_C_Sharp.Models.Lendarios>? Lendarios { get; set; }
    }
}

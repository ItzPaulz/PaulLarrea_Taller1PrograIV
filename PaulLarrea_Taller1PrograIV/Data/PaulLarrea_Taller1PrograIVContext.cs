using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PaulLarrea_Taller1PrograIV.Models;

namespace PaulLarrea_Taller1PrograIV.Data
{
    public class PaulLarrea_Taller1PrograIVContext : DbContext
    {
        public PaulLarrea_Taller1PrograIVContext (DbContextOptions<PaulLarrea_Taller1PrograIVContext> options)
            : base(options)
        {
        }

        public DbSet<PaulLarrea_Taller1PrograIV.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<PaulLarrea_Taller1PrograIV.Models.Estadio> Estadio { get; set; } = default!;
        public DbSet<PaulLarrea_Taller1PrograIV.Models.Jugador> Jugador { get; set; } = default!;
    }
}

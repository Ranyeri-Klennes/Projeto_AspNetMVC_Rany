using MarcarConsulta.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcarConsulta.Data
{
    public class PacienteContext : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<TipoExame> TiposExames { get; set; }
        public DbSet<Exames> Exames { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }
    }
}

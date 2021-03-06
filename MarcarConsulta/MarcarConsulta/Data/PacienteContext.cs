using MarcarConsulta.Models;
using Microsoft.EntityFrameworkCore;

namespace MarcarConsulta.Data
{
    public class PacienteContext : DbContext
    {
        public PacienteContext(DbContextOptions<PacienteContext> options) : base(options) { }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<TipoExame> TiposExames { get; set; }
        public DbSet<Exame> Exames { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=mssql.humbertobioca.com; Database=humberto2109292130_rany; User ID=humberto2109292130_rany; Password=bV_8sy01; Trusted_Connection=False");
        //}
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<PacienteExame>(entity =>
        //    {
        //        entity.HasKey(e => new { e.ExameId, e.PacienteId });
        //    });
        //}
    }
}

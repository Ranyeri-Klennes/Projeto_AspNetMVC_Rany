using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcarConsulta.Models
{
    public class Exame
    {
        public int Id { get; set; }
        public string Nome { get; set; }//> Ex:(hemograma, RaioX...) Até 100 chars.
        public string Obs { get; set; }//> Até 256 chars.
        public int TipoExameId { get; set; }//> Não pode ser nulo.

        public List<PacienteExame> PacientesExames { get; set; }//> Lista de Pacientes por exame.
    }
}

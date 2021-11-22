using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcarConsulta.Models
{
    public class PacienteExame//> Conexão Paciente-Exame
    {
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
        public int ExameId { get; set; }
        public Exame Exame { get; set; }
    }
}

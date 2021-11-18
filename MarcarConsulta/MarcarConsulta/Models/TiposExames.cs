using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcarConsulta.Models
{
    public class TiposExames
    {
        public int Id { get; set; }
        public string Nome  { get; set; }
        public string Descricao { get; set; }
        public int PacienteId { get; set; }
    }
}

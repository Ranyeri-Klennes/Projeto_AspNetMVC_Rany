using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcarConsulta.Models
{
    public class TipoExame
    {
        public int Id { get; set; }
        public string Nome  { get; set; }//> Até 100 chars.
        public string Descricao { get; set; }//> Até mil chars.

        public int ExameId { get; set; }//> Chave do Exame.
    }
}

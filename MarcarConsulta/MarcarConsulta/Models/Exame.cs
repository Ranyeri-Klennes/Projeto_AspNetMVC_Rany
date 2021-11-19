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
        public string Nome { get; set; }
        public string Obs { get; set; }
    }
}

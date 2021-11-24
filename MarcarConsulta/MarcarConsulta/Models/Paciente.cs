using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarcarConsulta.Models
{
    public class Paciente
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }//> Até 100 chars.
        public int CPF { get; set; }//> CPF válido e se já está cadastrado.
        public DateTime DataNascimento { get; set; }
        public string Genero { get; set; }
        public string Telefone { get; set; }//> Número válido.
        public string Email { get; set; }// E-mail válido.

        public List<PacienteExame> PacientesExames { get; set; } 
    }
}
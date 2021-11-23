using MarcarConsulta.Data;
using MarcarConsulta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MarcarConsulta.Controllers
{
    public class PacienteController : Controller
    {
        private readonly PacienteContext _contexto;

        public PacienteController(PacienteContext contexto)
        {
            _contexto = contexto;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _contexto.Pacientes.ToListAsync());
        }
        
        [HttpGet]
        public IActionResult CadastrarPaciente()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarPaciente(PacienteContext paciente)
        {
            if (true)
            {
                if (ModelState.IsValid)
                {
                    _contexto.Add(paciente);
                    await _contexto.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else return NotFound();
            }
        }

        [HttpGet]
        public IActionResult AtualizarPaciente(int Id)
        {
            if (true)
            {
                Paciente paciente = _contexto.Pacientes.Find(Id);
                return View(paciente);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AtualizarPaciente(int Id, Paciente paciente)
        {
            if (true)
            {
                _contexto.Update(paciente);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpGet]
        public IActionResult ExcluirPaciente(int Id)
        {
            if (true)
            {
                Paciente paciente = _contexto.Pacientes.Find(Id);
                return View(paciente);
            }
        }

        [HttpPost]
        public async Task<IActionResult> ExcluirPaciente(int Id, Paciente paciente)
        {
            if (true)
            {
                _contexto.Remove(paciente);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
        }
    }
}

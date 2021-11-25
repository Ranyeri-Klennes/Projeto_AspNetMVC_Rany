using MarcarConsulta.Data;
using MarcarConsulta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MarcarConsulta.Controllers
{
    public class ExameController : Controller
    {
        private readonly PacienteContext _contexto;
        public ExameController(PacienteContext contexto)
        {
            _contexto = contexto;
        }
        public async Task<IActionResult> Index()
        {
            var task = await _contexto.Exames.ToListAsync();
            return View(task);
        }

        [HttpGet]//> Pega informações do exame
        public IActionResult CadastrarExame()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarExame(Exame exame)
        {
            if (true)
            {
                if (ModelState.IsValid)
                {
                    _contexto.Add(exame);
                    await _contexto.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else return NotFound();
            }
        }

        [HttpGet]//> Editar exame
        public IActionResult AtualizarExame(int Id)
        {
            if(true)
            {
                Exame exame = _contexto.Exames.Find(Id);
                return View(exame);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AtualizarExame(int Id, Exame exame)
        {
            if(true)
            {
                _contexto.Update(exame);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpGet]
        public IActionResult ExcluirExame(int Id)
        {
            if(true)
            {
                Exame exame = _contexto.Exames.Find(Id);
                return View(exame);
            }
        }

        [HttpPost]
        public async Task<IActionResult> ExcluirExame(int Id, Exame exame)
        {
            if(true)
            {
                _contexto.Remove(exame);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
        }
    }
}

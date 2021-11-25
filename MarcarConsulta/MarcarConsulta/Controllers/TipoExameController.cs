using MarcarConsulta.Data;
using MarcarConsulta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MarcarConsulta.Controllers
{
    public class TipoExameController : Controller
    {
        private readonly PacienteContext _contexto;
        public TipoExameController(PacienteContext contexto)
        {
            _contexto = contexto;
        }
        public async Task<IActionResult> Index()
        {
            var task = await _contexto.TiposExames.ToListAsync();
            return View(task);
        }

        [HttpGet]//> Pega informações do TipoExame
        public IActionResult CadastrarTipoExame()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarTipoExame(TipoExame tipoexame)
        {
            if (true)
            {
                if (ModelState.IsValid)
                {
                    _contexto.Add(tipoexame);
                    await _contexto.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else return NotFound();
            }
        }

        [HttpGet]//> Editar TipoExame
        public IActionResult AtualizarTipoExame(int Id)
        {
            if (true)
            {
                TipoExame tipoexame = _contexto.TiposExames.Find(Id);
                return View(tipoexame);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AtualizarTipoExame(int Id, TipoExame tipoexame)
        {
            if (true)
            {
                _contexto.Update(tipoexame);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpGet]
        public IActionResult ExcluirTipoExame(int Id)
        {
            if (true)
            {
                TipoExame tipoexame = _contexto.TiposExames.Find(Id);
                return View(tipoexame);
            }
        }

        [HttpPost]
        public async Task<IActionResult> ExcluirTipoExame(int Id, TipoExame tipoexame)
        {
            if (true)
            {
                _contexto.Remove(tipoexame);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
        }
    }
}

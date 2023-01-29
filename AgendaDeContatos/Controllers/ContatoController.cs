using AgendaDeContatos.Models;
using AgendaDeContatos.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace AgendaDeContatos.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio1;
       public ContatoController(IContatoRepositorio contatoRepositorio) 
        {
            _contatoRepositorio1 = contatoRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult ApagarConfirmacao()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            _contatoRepositorio1.Adicionar(contato);
            return RedirectToAction("Index");
        }
    }
}

using CRUD_SEMANA6.Models;
using CRUD_SEMANA6.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_SEMANA6.Controllers
{
    public class Caminhao : Controller
    {
        public IActionResult Index()
        {
            List<CaminhaoModel> caminhoes = _caminhaoRepositorio.BuscarTodos();
            return View(caminhoes);
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
            CaminhaoModel caminhao = _caminhaoRepositorio.ListarPorID(id);
            return View(caminhao);
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            CaminhaoModel caminhao = _caminhaoRepositorio.ListarPorID(id);
            return View(caminhao);
        }

        public IActionResult Apagar(int id)
        {
            _caminhaoRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        private readonly ICaminhaoRepositorio _caminhaoRepositorio;
        public Caminhao(ICaminhaoRepositorio caminhaoRepositorio)
        {
            _caminhaoRepositorio = caminhaoRepositorio;
        }

        [HttpPost]
        public IActionResult Criar(CaminhaoModel caminhao)
        {
            _caminhaoRepositorio.Adicionar(caminhao);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Alterar(CaminhaoModel caminhao)
        {
            _caminhaoRepositorio.Atualizar(caminhao);
            return RedirectToAction("Index");
        }
    }
}

using CRUD_SEMANA6.Models;

namespace CRUD_SEMANA6.Repositorio

{
    public interface ICaminhaoRepositorio
    {
        CaminhaoModel ListarPorID(int id);
        List<CaminhaoModel> BuscarTodos();
        CaminhaoModel Adicionar(CaminhaoModel caminhao);
        CaminhaoModel Atualizar(CaminhaoModel caminhao);
        bool Apagar(int id);
    }

}

using CRUD_SEMANA6.Models;
using CRUD_SEMANA6.Data;

namespace CRUD_SEMANA6.Repositorio
{
    public class CaminhaoRepositorio : ICaminhaoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public CaminhaoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        
        public CaminhaoModel Adicionar(CaminhaoModel caminhao)
        {
            _bancoContext.Caminhoes.Add(caminhao);
            _bancoContext.SaveChanges();

            return caminhao;
        }

        public List<CaminhaoModel> BuscarTodos()
        {
            return _bancoContext.Caminhoes.ToList();
        }

        public CaminhaoModel ListarPorID(int id)
        {
            return _bancoContext.Caminhoes.FirstOrDefault(x => x.ID == id);
        }

        public CaminhaoModel Atualizar(CaminhaoModel caminhao)
        {
            CaminhaoModel caminhaoDB = ListarPorID(caminhao.ID);

            if (caminhaoDB == null) throw new System.Exception("Houve um erro na atualização de cadastro");

            caminhaoDB.Nome = caminhao.Nome;
            caminhaoDB.Descricao = caminhao.Descricao;
            caminhaoDB.DatadeCriacao = caminhao.DatadeCriacao;

            _bancoContext.Caminhoes.Update(caminhaoDB);
            _bancoContext.SaveChanges();

            return caminhaoDB;
        }

        public bool Apagar(int id)
        {
            CaminhaoModel caminhaoDB = ListarPorID(id);

            if (caminhaoDB == null) throw new System.Exception("Houve um erro na deleção do caminhão!");

            _bancoContext.Caminhoes.Remove(caminhaoDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}

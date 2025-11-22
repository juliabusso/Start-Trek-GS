using FIAP.CP2.Model;
using System.Collections.Generic;

namespace FIAP.CP2.Model.Interfaces
{
    public interface IProfissaoFuturaRepository
    {
        List<ProfissaoFuturaModel> ListarTodas();
        ProfissaoFuturaModel? ObterPorId(int id);
        void Adicionar(ProfissaoFuturaModel model);
        void Atualizar(ProfissaoFuturaModel model);
        void Remover(int id);
    }
}
 
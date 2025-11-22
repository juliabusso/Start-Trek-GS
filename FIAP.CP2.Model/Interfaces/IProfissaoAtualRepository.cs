using FIAP.CP2.Model;
using System.Collections.Generic;

namespace FIAP.CP2.Model.Interfaces
{
    public interface IProfissaoAtualRepository
    {
        List<ProfissaoAtualModel> ListarTodas();
        ProfissaoAtualModel? ObterPorId(int id);
        void Adicionar(ProfissaoAtualModel model);
        void Atualizar(ProfissaoAtualModel model);
        void Remover(int id);
    }
}

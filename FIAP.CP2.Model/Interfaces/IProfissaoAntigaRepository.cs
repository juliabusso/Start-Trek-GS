using System.Collections.Generic;

namespace FIAP.CP2.Model.Interfaces
{
    public interface IProfissaoAntigaRepository
    {
        ProfissaoAntigaModel ObterPorId(int id);
        List<ProfissaoAntigaModel> ListarTodas();
        void Adicionar(ProfissaoAntigaModel model);
        void Atualizar(ProfissaoAntigaModel model);
        void Deletar(int id);
    }
}

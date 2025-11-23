using System.Collections.Generic;
using FIAP.CP2.Domain.Entities;

namespace FIAP.CP2.Domain.Interfaces.Repositories
{
    public interface IProfissaoAtualRepository
    {
        ProfissaoAtual? ObterPorId(int id);
        List<ProfissaoAtual> ListarTodas();
        void Adicionar(ProfissaoAtual entidade);
        void Atualizar(ProfissaoAtual entidade);
        void Remover(int id);
    }
}

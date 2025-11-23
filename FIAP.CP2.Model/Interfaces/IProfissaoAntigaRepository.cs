using System.Collections.Generic;
using FIAP.CP2.Domain.Entities;

namespace FIAP.CP2.Domain.Interfaces.Repositories
{
    public interface IProfissaoAntigaRepository
    {
        ProfissaoAntiga? ObterPorId(int id);
        List<ProfissaoAntiga> ListarTodas();
        void Adicionar(ProfissaoAntiga entidade);
        void Atualizar(ProfissaoAntiga entidade);
        void Remover(int id);
    }
}

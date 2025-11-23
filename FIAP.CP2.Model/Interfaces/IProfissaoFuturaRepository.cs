using System.Collections.Generic;
using FIAP.CP2.Domain.Entities;

namespace FIAP.CP2.Domain.Interfaces.Repositories
{
    public interface IProfissaoFuturaRepository
    {
        ProfissaoFutura? ObterPorId(int id);
        List<ProfissaoFutura> ListarTodas();
        void Adicionar(ProfissaoFutura entidade);
        void Atualizar(ProfissaoFutura entidade);
        void Remover(int id);
    }
}

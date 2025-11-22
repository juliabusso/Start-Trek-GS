using FIAP.CP2.Model.Entities;

namespace FIAP.CP2.Model.Services
{
    public interface IProfissaoFuturaDomainService
    {
        void ValidarCriacao(ProfissaoFuturaModel profissao);
        void ValidarAtualizacao(ProfissaoFuturaModel profissao);
        void ValidarExclusao(ProfissaoFuturaModel profissao);
    }
}

using FIAP.CP2.Model.Entities;

namespace FIAP.CP2.Model.Services
{
    public interface IProfissaoAtualDomainService
    {
        void ValidarCriacao(ProfissaoAtualModel profissao);
        void ValidarAtualizacao(ProfissaoAtualModel profissao);
        void ValidarExclusao(ProfissaoAtualModel profissao);
    }
}

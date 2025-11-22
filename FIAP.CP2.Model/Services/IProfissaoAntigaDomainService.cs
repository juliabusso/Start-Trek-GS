using FIAP.CP2.Model.Entities;

namespace FIAP.CP2.Model.Services
{
    public interface IProfissaoAntigaDomainService
    {
        void ValidarCriacao(ProfissaoAntigaModel profissao);
        void ValidarAtualizacao(ProfissaoAntigaModel profissao);
        void ValidarExclusao(ProfissaoAntigaModel profissao);
    }
}

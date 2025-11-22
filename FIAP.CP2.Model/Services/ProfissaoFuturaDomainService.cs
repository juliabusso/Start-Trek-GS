using FIAP.CP2.Model.Exceptions;
using FIAP.CP2.Model.Interfaces;

namespace FIAP.CP2.Model.Services
{
    public class ProfissaoFuturaDomainService
    {
        private readonly IProfissaoFuturaRepository _repo;

        public ProfissaoFuturaDomainService(IProfissaoFuturaRepository repo)
        {
            _repo = repo;
        }

        public void CadastrarProfissao(ProfissaoFuturaModel model)
        {
            if (model.AnoPrevisto < 2026)
                throw new DomainException("Profissões futuras devem ter previsão após 2025.");

            var lista = _repo.ListarTodas();
            if (lista.Any(x => x.Nome == model.Nome))
                throw new DomainException("Já existe uma profissão futura com esse nome.");

            _repo.Adicionar(model);
        }

        public void AtualizarProfissao(ProfissaoFuturaModel model)
        {
            var existente = _repo.ObterPorId(model.Id);
            if (existente == null)
                throw new DomainException("Profissão futura não encontrada.");

            if (model.AnoPrevisto < 2026)
                throw new DomainException("Profissões futuras devem ter previsão após 2025.");

            _repo.Atualizar(model);
        }
    }
}

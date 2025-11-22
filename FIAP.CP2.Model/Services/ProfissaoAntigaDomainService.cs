using FIAP.CP2.Model.Exceptions;
using FIAP.CP2.Model.Interfaces;

namespace FIAP.CP2.Model.Services
{
    public class ProfissaoAntigaDomainService
    {
        private readonly IProfissaoAntigaRepository _repo;

        public ProfissaoAntigaDomainService(IProfissaoAntigaRepository repo)
        {
            _repo = repo;
        }

        // Regra de negócio: não pode cadastrar profissão duplicada
        public void CadastrarProfissao(ProfissaoAntigaModel model)
        {
            var lista = _repo.ListarTodas();
            if (lista.Any(x => x.Nome == model.Nome))
                throw new DomainException("Já existe uma profissão antiga com esse nome.");

            _repo.Adicionar(model);
        }

        // Regra de negócio: atualização válida
        public void AtualizarProfissao(ProfissaoAntigaModel model)
        {
            var existente = _repo.ObterPorId(model.Id);
            if (existente == null)
                throw new DomainException("Profissão não encontrada.");

            _repo.Atualizar(model);
        }
    }
}

using FIAP.CP2.Model.Exceptions;
using FIAP.CP2.Model.Interfaces;

namespace FIAP.CP2.Model.Services
{
	public class ProfissaoAtualDomainService
	{
		private readonly IProfissaoAtualRepository _repo;

		public ProfissaoAtualDomainService(IProfissaoAtualRepository repo)
		{
			_repo = repo;
		}

		public void CadastrarProfissao(ProfissaoAtualModel model)
		{
			if (model.AnoOrigem < 1951)
				throw new DomainException("Profissões atuais devem ter origem após 1950.");

			var lista = _repo.ListarTodas();
			if (lista.Any(x => x.Nome == model.Nome))
				throw new DomainException("Já existe uma profissão atual com esse nome.");

			_repo.Adicionar(model);
		}

		public void AtualizarProfissao(ProfissaoAtualModel model)
		{
			var existente = _repo.ObterPorId(model.Id);
			if (existente == null)
				throw new DomainException("Profissão atual não encontrada.");

			if (model.AnoOrigem < 1951)
				throw new DomainException("Profissões atuais devem ter origem após 1950.");

			_repo.Atualizar(model);
		}
	}
}

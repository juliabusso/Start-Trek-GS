using FIAP.CP2.Application.DTOs;
using FIAP.CP2.Application.Interfaces;
using FIAP.CP2.Model.Entities;
using FIAP.CP2.Model.Interfaces;

namespace FIAP.CP2.Application.Services
{
    public class ProfissaoAtualAppService : IProfissaoAtualAppService
    {
        private readonly IProfissaoAtualDomainService _domainService;

        public ProfissaoAtualAppService(IProfissaoAtualDomainService domainService)
        {
            _domainService = domainService;
        }

        public async Task<IEnumerable<ProfissaoAtualDto>> ListarAsync()
        {
            var entidades = await _domainService.ListarAsync();

            return entidades.Select(e => new ProfissaoAtualDto
            {
                Id = e.Id,
                Nome = e.Nome,
                Descricao = e.Descricao,
                AreaAtuacao = e.AreaAtuacao
            });
        }

        public async Task<ProfissaoAtualDto?> ObterPorIdAsync(int id)
        {
            var e = await _domainService.ObterPorIdAsync(id);
            if (e == null) return null;

            return new ProfissaoAtualDto
            {
                Id = e.Id,
                Nome = e.Nome,
                Descricao = e.Descricao,
                AreaAtuacao = e.AreaAtuacao
            };
        }

        public async Task AdicionarAsync(ProfissaoAtualDto dto)
        {
            var entidade = new ProfissaoAtualModel(
                dto.Nome,
                dto.Descricao,
                dto.AreaAtuacao
            );

            await _domainService.AdicionarAsync(entidade);
        }

        public async Task AtualizarAsync(ProfissaoAtualDto dto)
        {
            var entidade = await _domainService.ObterPorIdAsync(dto.Id);
            if (entidade == null)
                throw new Exception("Profissão não encontrada.");

            entidade.AlterarDados(dto.Nome, dto.Descricao, dto.AreaAtuacao);

            await _domainService.AtualizarAsync(entidade);
        }

        public async Task RemoverAsync(int id)
        {
            await _domainService.RemoverAsync(id);
        }
    }
}

using FIAP.CP2.Application.DTOs;
using FIAP.CP2.Application.Interfaces;
using FIAP.CP2.Model.Entities;
using FIAP.CP2.Model.Interfaces;

namespace FIAP.CP2.Application.Services
{
    public class ProfissaoAntigaAppService : IProfissaoAntigaAppService
    {
        private readonly IProfissaoAntigaDomainService _domainService;

        public ProfissaoAntigaAppService(IProfissaoAntigaDomainService domainService)
        {
            _domainService = domainService;
        }

        public async Task<IEnumerable<ProfissaoAntigaDto>> ListarAsync()
        {
            var entidades = await _domainService.ListarAsync();

            return entidades.Select(e => new ProfissaoAntigaDto
            {
                Id = e.Id,
                Nome = e.Nome,
                Descricao = e.Descricao,
                MotivoExtincao = e.MotivoExtincao
            });
        }

        public async Task<ProfissaoAntigaDto?> ObterPorIdAsync(int id)
        {
            var e = await _domainService.ObterPorIdAsync(id);

            if (e == null) return null;

            return new ProfissaoAntigaDto
            {
                Id = e.Id,
                Nome = e.Nome,
                Descricao = e.Descricao,
                MotivoExtincao = e.MotivoExtincao
            };
        }

        public async Task AdicionarAsync(ProfissaoAntigaDto dto)
        {
            var entidade = new ProfissaoAntigaModel(
                dto.Nome,
                dto.Descricao,
                dto.MotivoExtincao
            );

            await _domainService.AdicionarAsync(entidade);
        }

        public async Task AtualizarAsync(ProfissaoAntigaDto dto)
        {
            var entidade = await _domainService.ObterPorIdAsync(dto.Id);

            if (entidade == null)
                throw new Exception("Profissão não encontrada.");

            entidade.AlterarDados(dto.Nome, dto.Descricao, dto.MotivoExtincao);

            await _domainService.AtualizarAsync(entidade);
        }

        public async Task RemoverAsync(int id)
        {
            await _domainService.RemoverAsync(id);
        }
    }
}

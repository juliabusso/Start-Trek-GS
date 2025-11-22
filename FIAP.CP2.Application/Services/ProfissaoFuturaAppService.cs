using FIAP.CP2.Application.DTOs;
using FIAP.CP2.Application.Interfaces;
using FIAP.CP2.Model.Entities;
using FIAP.CP2.Model.Interfaces;

namespace FIAP.CP2.Application.Services
{
    public class ProfissaoFuturaAppService : IProfissaoFuturaAppService
    {
        private readonly IProfissaoFuturaDomainService _domainService;

        public ProfissaoFuturaAppService(IProfissaoFuturaDomainService domainService)
        {
            _domainService = domainService;
        }

        public async Task<IEnumerable<ProfissaoFuturaDto>> ListarAsync()
        {
            var entidades = await _domainService.ListarAsync();

            return entidades.Select(e => new ProfissaoFuturaDto
            {
                Id = e.Id,
                Nome = e.Nome,
                Descricao = e.Descricao,
                TecnologiaRelacionada = e.TecnologiaRelacionada
            });
        }

        public async Task<ProfissaoFuturaDto?> ObterPorIdAsync(int id)
        {
            var e = await _domainService.ObterPorIdAsync(id);
            if (e == null) return null;

            return new ProfissaoFuturaDto
            {
                Id = e.Id,
                Nome = e.Nome,
                Descricao = e.Descricao,
                TecnologiaRelacionada = e.TecnologiaRelacionada
            };
        }

        public async Task AdicionarAsync(ProfissaoFuturaDto dto)
        {
            var entidade = new ProfissaoFuturaModel(
                dto.Nome,
                dto.Descricao,
                dto.TecnologiaRelacionada
            );

            await _domainService.AdicionarAsync(entidade);
        }

        public async Task AtualizarAsync(ProfissaoFuturaDto dto)
        {
            var entidade = await _domainService.ObterPorIdAsync(dto.Id);
            if (entidade == null)
                throw new Exception("Profissão não encontrada.");

            entidade.AlterarDados(dto.Nome, dto.Descricao, dto.TecnologiaRelacionada);

            await _domainService.AtualizarAsync(entidade);
        }

        public async Task RemoverAsync(int id)
        {
            await _domainService.RemoverAsync(id);
        }
    }
}

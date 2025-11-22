using FIAP.CP2.Application.DTOs;

namespace FIAP.CP2.Application.Interfaces
{
    public interface IProfissaoAtualAppService
    {
        Task<List<ProfissaoAtualDto>> ListarAsync();
        Task<ProfissaoAtualDto?> ObterPorIdAsync(int id);
        Task<ProfissaoAtualDto> CriarAsync(ProfissaoAtualDto dto);
        Task<ProfissaoAtualDto> AtualizarAsync(int id, ProfissaoAtualDto dto);
        Task<bool> DeletarAsync(int id);
    }
}

using FIAP.CP2.Application.DTOs;

namespace FIAP.CP2.Application.Interfaces
{
    public interface IProfissaoFuturaAppService
    {
        Task<List<ProfissaoFuturaDto>> ListarAsync();
        Task<ProfissaoFuturaDto?> ObterPorIdAsync(int id);
        Task<ProfissaoFuturaDto> CriarAsync(ProfissaoFuturaDto dto);
        Task<ProfissaoFuturaDto> AtualizarAsync(int id, ProfissaoFuturaDto dto);
        Task<bool> DeletarAsync(int id);
    }
}

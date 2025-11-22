using FIAP.CP2.Application.DTOs;

namespace FIAP.CP2.Application.Interfaces
{
    public interface IProfissaoAntigaAppService
    {
        Task<List<ProfissaoAntigaDto>> ListarAsync();
        Task<ProfissaoAntigaDto?> ObterPorIdAsync(int id);
        Task<ProfissaoAntigaDto> CriarAsync(ProfissaoAntigaDto dto);
        Task<ProfissaoAntigaDto> AtualizarAsync(int id, ProfissaoAntigaDto dto);
        Task<bool> DeletarAsync(int id);
    }
}

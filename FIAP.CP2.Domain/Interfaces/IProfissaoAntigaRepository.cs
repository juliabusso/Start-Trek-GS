using FIAP.CP2.Domain.Entities;

namespace FIAP.CP2.Domain.Repositories
{
    public interface IProfissaoAntigaRepository
    {
        Task<IEnumerable<ProfissaoAntiga>> GetAllAsync();
        Task<ProfissaoAntiga?> GetByIdAsync(int id);
        Task AddAsync(ProfissaoAntiga entity);
        Task UpdateAsync(ProfissaoAntiga entity);
        Task DeleteAsync(int id);
    }
}

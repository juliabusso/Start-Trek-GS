using FIAP.CP2.Domain.Entities;

namespace FIAP.CP2.Domain.Repositories
{
    public interface IProfissaoAtualRepository
    {
        Task<IEnumerable<ProfissaoAtual>> GetAllAsync();
        Task<ProfissaoAtual?> GetByIdAsync(int id);
        Task AddAsync(ProfissaoAtual entity);
        Task UpdateAsync(ProfissaoAtual entity);
        Task DeleteAsync(int id);
    }
}

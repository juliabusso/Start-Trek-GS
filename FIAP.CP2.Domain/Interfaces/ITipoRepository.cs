using FIAP.CP2.Domain.Entities;

namespace FIAP.CP2.Domain.Repositories
{
    public interface ITipoRepository
    {
        Task<IEnumerable<Tipo>> GetAllAsync();
        Task<Tipo?> GetByIdAsync(int id);
        Task AddAsync(Tipo entity);
        Task UpdateAsync(Tipo entity);
        Task DeleteAsync(int id);
    }
}

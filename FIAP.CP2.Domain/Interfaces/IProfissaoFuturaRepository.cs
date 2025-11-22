using FIAP.CP2.Domain.Entities;

namespace FIAP.CP2.Domain.Repositories
{
    public interface IProfissaoFuturaRepository
    {
        Task<IEnumerable<ProfissaoFutura>> GetAllAsync();
        Task<ProfissaoFutura?> GetByIdAsync(int id);
        Task AddAsync(ProfissaoFutura entity);
        Task UpdateAsync(ProfissaoFutura entity);
        Task DeleteAsync(int id);
    }
}

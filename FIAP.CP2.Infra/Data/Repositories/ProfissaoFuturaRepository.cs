using FIAP.CP2.Data;
using FIAP.CP2.Model;
using FIAP.CP2.Model.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FIAP.CP2.Infra.Data.Repositories
{
    public class ProfissaoFuturaRepository : IProfissaoFuturaRepository
    {
        private readonly ApplicationDbContext _context;

        public ProfissaoFuturaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<ProfissaoFuturaModel> ListarTodas()
        {
            return _context.ProfissoesFuturas.AsNoTracking().ToList();
        }

        public ProfissaoFuturaModel? ObterPorId(int id)
        {
            return _context.ProfissoesFuturas.FirstOrDefault(p => p.Id == id);
        }

        public void Adicionar(ProfissaoFuturaModel model)
        {
            _context.ProfissoesFuturas.Add(model);
            _context.SaveChanges();
        }

        public void Atualizar(ProfissaoFuturaModel model)
        {
            _context.ProfissoesFuturas.Update(model);
            _context.SaveChanges();
        }

        public void Remover(int id)
        {
            var entidade = _context.ProfissoesFuturas.FirstOrDefault(p => p.Id == id);

            if (entidade != null)
            {
                _context.ProfissoesFuturas.Remove(entidade);
                _context.SaveChanges();
            }
        }
    }
}

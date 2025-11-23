using FIAP.CP2.Data;
using FIAP.CP2.Model;
using FIAP.CP2.Model.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FIAP.CP2.Infra.Data.Repositories
{
    public class ProfissaoAntigaRepository : IProfissaoAntigaRepository
    {
        private readonly ApplicationDbContext _context;

        public ProfissaoAntigaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<ProfissaoAntigaModel> ListarTodas()
        {
            return _context.ProfissoesAntigas.AsNoTracking().ToList();
        }

        public ProfissaoAntigaModel ObterPorId(int id)
        {
            return _context.ProfissoesAntigas.FirstOrDefault(p => p.Id == id);
        }

        public void Adicionar(ProfissaoAntigaModel model)
        {
            _context.ProfissoesAntigas.Add(model);
            _context.SaveChanges();
        }

        public void Atualizar(ProfissaoAntigaModel model)
        {
            _context.ProfissoesAntigas.Update(model);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            var entidade = _context.ProfissoesAntigas.FirstOrDefault(p => p.Id == id);

            if (entidade != null)
            {
                _context.ProfissoesAntigas.Remove(entidade);
                _context.SaveChanges();
            }
        }
    }
}

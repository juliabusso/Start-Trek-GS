using FIAP.CP2.Data;
using FIAP.CP2.Model;
using FIAP.CP2.Model.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FIAP.CP2.Infra.Data.Repositories
{
    public class ProfissaoAtualRepository : IProfissaoAtualRepository
    {
        private readonly ApplicationDbContext _context;

        public ProfissaoAtualRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<ProfissaoAtualModel> ListarTodas()
        {
            return _context.ProfissoesAtuais.AsNoTracking().ToList();
        }

        public ProfissaoAtualModel? ObterPorId(int id)
        {
            return _context.ProfissoesAtuais.FirstOrDefault(p => p.Id == id);
        }

        public void Adicionar(ProfissaoAtualModel model)
        {
            _context.ProfissoesAtuais.Add(model);
            _context.SaveChanges();
        }

        public void Atualizar(ProfissaoAtualModel model)
        {
            _context.ProfissoesAtuais.Update(model);
            _context.SaveChanges();
        }

        public void Remover(int id)
        {
            var entidade = _context.ProfissoesAtuais.FirstOrDefault(p => p.Id == id);

            if (entidade != null)
            {
                _context.ProfissoesAtuais.Remove(entidade);
                _context.SaveChanges();
            }
        }
    }
}

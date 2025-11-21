using Fiap.CP2.Business;
using FIAP.CP2.Data;
using FIAP.CP2.Model;
using System.Collections.Generic;

namespace FIAP.CP2.Business
{
    public class AlunoService : IAlunoService
    {
        private readonly ApplicationDbContext _context;

        public AlunoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<AlunoModel> ListarTodos()
        {
            return _context.Alunos.ToList();
        }
    }
}

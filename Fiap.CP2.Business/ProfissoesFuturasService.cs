using FIAP.CP2.Data;
using FIAP.CP2.Model;
using System.Collections.Generic;
using System.Linq;

public class ProfissoesFuturasService : IProfissoesFuturasService
{
    private readonly ApplicationDbContext _context;

    public ProfissoesFuturasService(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<ProfissaoFuturaModel> ListarTodas()
    {
        return _context.ProfissoesFuturas.ToList();
    }
}

using FIAP.CP2.Data;
using FIAP.CP2.Model;
using System.Collections.Generic;
using System.Linq;

public class ProfissoesAntigasService : IProfissoesAntigasService
{
    private readonly ApplicationDbContext _context;

    public ProfissoesAntigasService(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<ProfissaoAntigaModel> ListarTodas()
    {
        return _context.ProfissoesAntigas.ToList();
    }
}

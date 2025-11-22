using FIAP.CP2.Data;
using FIAP.CP2.Model;
using System.Collections.Generic;
using System.Linq;

public class ProfissoesAtuaisService : IProfissoesAtuaisService
{
	private readonly ApplicationDbContext _context;

	public ProfissoesAtuaisService(ApplicationDbContext context)
	{
		_context = context;
	}

	public List<ProfissaoAtualModel> ListarTodas()
	{
		return _context.ProfissoesAtuais.ToList();
	}
}

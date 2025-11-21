using System;
namespace FIAP.CP2.Model
{
    public class JogoEducativoModel
    {
        public string? Id { get; set; }
        public required string Titulo { get; set; }
        public string? Descricao { get; set; }
        public string? TemaProfissaoId { get; set; } // relation to ProfissaoModel.Id
    }
}

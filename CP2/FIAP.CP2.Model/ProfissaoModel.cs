using System;
namespace FIAP.CP2.Model
{
    public class ProfissaoModel
    {
        public string? Id { get; set; }
        public required string Nome { get; set; }
        public required string Status { get; set; } // Extinta / Atual / Futura
        public string? Descricao { get; set; }
        public string? TecnologiasRelacionadas { get; set; }
    }
}

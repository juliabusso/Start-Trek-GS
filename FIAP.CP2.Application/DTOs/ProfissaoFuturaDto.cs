namespace FIAP.CP2.Application.DTOs
{
    public class ProfissaoFuturaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public decimal? SalarioPrevisto { get; set; }
        public string Area { get; set; } = string.Empty;
        public int AnoEstimado { get; set; }
    }
}

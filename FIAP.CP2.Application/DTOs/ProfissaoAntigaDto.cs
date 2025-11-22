namespace FIAP.CP2.Application.DTOs
{
    public class ProfissaoAntigaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public decimal? Salario { get; set; }
        public string Area { get; set; } = string.Empty;
    }
}

namespace FIAP.CP2.Model
{
    public class JogoEducativo
    {
        public string Nome { get; set; }
        public string Desenvolvedor { get; set; }
        public string Linguagem { get; set; }

        public JogoEducativo(string nome, string desenvolvedor, string linguagem)
        {
            Nome = nome;
            Desenvolvedor = desenvolvedor;
            Linguagem = linguagem;
        }
    }
}

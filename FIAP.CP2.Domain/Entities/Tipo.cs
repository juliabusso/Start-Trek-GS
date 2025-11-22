using FIAP.CP2.Domain.Exceptions;

namespace FIAP.CP2.Domain.Entities
{
    public class Tipo
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }

        protected Tipo() { }

        public Tipo(string nome)
        {
            SetNome(nome);
        }

        public void SetNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new DomainException("O nome do tipo é obrigatório.");

            Nome = nome;
        }
    }
}

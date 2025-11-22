using FIAP.CP2.Domain.Exceptions;

namespace FIAP.CP2.Domain.Entities
{
    public class ProfissaoAntiga
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string MotivoExtincao { get; private set; }
        public string SubstituidaPor { get; private set; }

        protected ProfissaoAntiga() { } // EF Core

        public ProfissaoAntiga(string nome, string motivoExtincao, string substituidaPor)
        {
            SetNome(nome);
            SetMotivoExtincao(motivoExtincao);
            SetSubstituidaPor(substituidaPor);
        }

        public void SetNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new DomainException("O nome da profissão antiga não pode ser vazio.");

            Nome = nome;
        }

        public void SetMotivoExtincao(string motivo)
        {
            if (string.IsNullOrWhiteSpace(motivo))
                throw new DomainException("O motivo de extinção é obrigatório.");

            MotivoExtincao = motivo;
        }

        public void SetSubstituidaPor(string substituta)
        {
            if (string.IsNullOrWhiteSpace(substituta))
                throw new DomainException("A profissão substituta deve ser informada.");

            SubstituidaPor = substituta;
        }
    }
}

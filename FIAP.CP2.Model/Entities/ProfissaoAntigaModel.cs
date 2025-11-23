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

        // Invariantes e validações
        private void SetNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome da profissão é obrigatório.");

            if (nome.Length < 3)
                throw new ArgumentException("O nome deve ter pelo menos 3 caracteres.");

            Nome = nome;
        }

        private void SetMotivoExtincao(string motivo)
        {
            if (string.IsNullOrWhiteSpace(motivo))
                throw new ArgumentException("O motivo da extinção é obrigatório.");

            MotivoExtincao = motivo;
        }

        private void SetSubstituidaPor(string substituida)
        {
            if (string.IsNullOrWhiteSpace(substituida))
                throw new ArgumentException("A profissão substituta deve ser informada.");

            SubstituidaPor = substituida;
        }

        // Método de atualização seguro
        public void Atualizar(string nome, string motivo, string substituidaPor)
        {
            SetNome(nome);
            SetMotivoExtincao(motivo);
            SetSubstituidaPor(substituidaPor);
        }
    }
}

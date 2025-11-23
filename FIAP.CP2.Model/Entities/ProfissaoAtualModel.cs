namespace FIAP.CP2.Domain.Entities
{
    public class ProfissaoAtual
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string RiscoExtincao { get; private set; }
        public string Motivo { get; private set; }

        protected ProfissaoAtual() { }

        public ProfissaoAtual(string nome, string riscoExtincao, string motivo)
        {
            SetNome(nome);
            SetRiscoExtincao(riscoExtincao);
            SetMotivo(motivo);
        }

        private void SetNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome é obrigatório.");

            Nome = nome;
        }

        private void SetRiscoExtincao(string risco)
        {
            if (string.IsNullOrWhiteSpace(risco))
                throw new ArgumentException("O risco de extinção deve ser informado (ex: alto, médio, baixo).");

            RiscoExtincao = risco;
        }

        private void SetMotivo(string motivo)
        {
            if (string.IsNullOrWhiteSpace(motivo))
                throw new ArgumentException("O motivo é obrigatório.");

            Motivo = motivo;
        }

        public void Atualizar(string nome, string riscoExtincao, string motivo)
        {
            SetNome(nome);
            SetRiscoExtincao(riscoExtincao);
            SetMotivo(motivo);
        }
    }
}

namespace FIAP.CP2.Domain.Entities
{
    public class ProfissaoFutura
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string MotivoExistencia { get; private set; }
        public string ChanceDeExistir { get; private set; }

        protected ProfissaoFutura() { }

        public ProfissaoFutura(string nome, string motivoExistencia, string chanceDeExistir)
        {
            SetNome(nome);
            SetMotivoExistencia(motivoExistencia);
            SetChanceDeExistir(chanceDeExistir);
        }

        private void SetNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome da profissão futura é obrigatório.");

            Nome = nome;
        }

        private void SetMotivoExistencia(string motivo)
        {
            if (string.IsNullOrWhiteSpace(motivo))
                throw new ArgumentException("O motivo de existência deve ser informado.");

            MotivoExistencia = motivo;
        }

        private void SetChanceDeExistir(string chance)
        {
            if (string.IsNullOrWhiteSpace(chance))
                throw new ArgumentException("A chance de existir deve ser informada.");

            ChanceDeExistir = chance;
        }

        public void Atualizar(string nome, string motivoExistencia, string chance)
        {
            SetNome(nome);
            SetMotivoExistencia(motivoExistencia);
            SetChanceDeExistir(chance);
        }
    }
}

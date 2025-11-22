using FIAP.CP2.Domain.Exceptions;

namespace FIAP.CP2.Domain.Entities
{
    public class ProfissaoFutura
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string PorqueVaiExistir { get; private set; }
        public int Probabilidade { get; private set; } // 0–100%

        protected ProfissaoFutura() { }

        public ProfissaoFutura(string nome, string motivo, int probabilidade)
        {
            SetNome(nome);
            SetPorqueVaiExistir(motivo);
            SetProbabilidade(probabilidade);
        }

        public void SetNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new DomainException("O nome da profissão futura é obrigatório.");

            Nome = nome;
        }

        public void SetPorqueVaiExistir(string motivo)
        {
            if (string.IsNullOrWhiteSpace(motivo))
                throw new DomainException("O motivo da existência futura deve ser informado.");

            PorqueVaiExistir = motivo;
        }

        public void SetProbabilidade(int prob)
        {
            if (prob < 0 || prob > 100)
                throw new DomainException("A probabilidade deve estar entre 0 e 100.");

            Probabilidade = prob;
        }
    }
}

using FIAP.CP2.Domain.Exceptions;

namespace FIAP.CP2.Domain.Entities
{
    public class ProfissaoAtual
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public bool RiscoAutomacao { get; private set; } // probabilidade da profissão sumir

        protected ProfissaoAtual() { }

        public ProfissaoAtual(string nome, string descricao, bool riscoAutomacao)
        {
            SetNome(nome);
            SetDescricao(descricao);
            SetRiscoAutomacao(riscoAutomacao);
        }

        public void SetNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new DomainException("O nome da profissão atual é obrigatório.");

            Nome = nome;
        }

        public void SetDescricao(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao))
                throw new DomainException("A descrição é obrigatória.");

            Descricao = descricao;
        }

        public void SetRiscoAutomacao(bool risco)
        {
            RiscoAutomacao = risco;
        }
    }
}

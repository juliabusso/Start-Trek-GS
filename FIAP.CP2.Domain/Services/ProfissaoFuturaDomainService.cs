using FIAP.CP2.Domain.Entities;
using FIAP.CP2.Domain.Exceptions;

namespace FIAP.CP2.Domain.Services
{
    public class ProfissaoFuturaDomainService
    {
        public void Validar(ProfissaoFutura profession)
        {
            if (profession == null)
                throw new DomainException("A profissão futura não pode ser nula.");

            if (string.IsNullOrWhiteSpace(profession.Nome))
                throw new DomainException("O nome da profissão futura é obrigatório.");

            if (profession.Nome.Length < 3)
                throw new DomainException("O nome da profissão futura deve ter pelo menos 3 caracteres.");

            if (profession.Nome.Length > 100)
                throw new DomainException("O nome da profissão futura deve ter no máximo 100 caracteres.");
        }
    }
}

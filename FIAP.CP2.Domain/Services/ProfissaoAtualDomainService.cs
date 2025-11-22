using FIAP.CP2.Domain.Entities;
using FIAP.CP2.Domain.Exceptions;

namespace FIAP.CP2.Domain.Services
{
    public class ProfissaoAtualDomainService
    {
        public void Validar(ProfissaoAtual profession)
        {
            if (profession == null)
                throw new DomainException("A profissão atual não pode ser nula.");

            if (string.IsNullOrWhiteSpace(profession.Nome))
                throw new DomainException("O nome da profissão atual é obrigatório.");

            if (profession.Nome.Length < 3)
                throw new DomainException("O nome da profissão atual deve ter pelo menos 3 caracteres.");

            if (profession.Nome.Length > 100)
                throw new DomainException("O nome da profissão atual deve ter no máximo 100 caracteres.");
        }
    }
}

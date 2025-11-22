using FIAP.CP2.Domain.Entities;
using FIAP.CP2.Domain.Exceptions;

namespace FIAP.CP2.Domain.Services
{
    public class TipoDomainService
    {
        public void Validar(Tipo tipo)
        {
            if (tipo == null)
                throw new DomainException("O tipo não pode ser nulo.");

            if (string.IsNullOrWhiteSpace(tipo.Nome))
                throw new DomainException("O nome do tipo é obrigatório.");

            if (tipo.Nome.Length < 3)
                throw new DomainException("O nome do tipo deve ter pelo menos 3 caracteres.");

            if (tipo.Nome.Length > 50)
                throw new DomainException("O nome do tipo deve ter no máximo 50 caracteres.");
        }
    }
}

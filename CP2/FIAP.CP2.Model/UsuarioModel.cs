using System;
namespace FIAP.CP2.Model
{
    public class UsuarioModel
    {
        public string? Id { get; set; }
        public required string Nome { get; set; }
        public string? Email { get; set; }
        public string? Interesse { get; set; }
    }
}

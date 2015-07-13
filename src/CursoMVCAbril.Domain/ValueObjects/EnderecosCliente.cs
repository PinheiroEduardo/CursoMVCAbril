using System;

namespace CursoMVCAbril.Domain.ValueObjects
{
    public class EnderecosCliente
    {
        public Guid EnderecoId { get; set; }
        public Guid ClienteId { get; set; }
    }
}
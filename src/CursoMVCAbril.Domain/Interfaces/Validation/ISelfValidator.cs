using CursoMVCAbril.Domain.ValueObjects;

namespace CursoMVCAbril.Domain.Interfaces.Validation
{
    public interface ISelfValidator
    {
        ValidationResult ResultadoValidacao { get; }
        bool IsValid();
    }
}
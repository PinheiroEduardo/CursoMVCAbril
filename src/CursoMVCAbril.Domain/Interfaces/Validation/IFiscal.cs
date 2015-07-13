using CursoMVCAbril.Domain.ValueObjects;

namespace CursoMVCAbril.Domain.Interfaces.Validation
{
    public interface IFiscal<in TEntity>
    {
        ValidationResult Validar(TEntity entity);
    }
}
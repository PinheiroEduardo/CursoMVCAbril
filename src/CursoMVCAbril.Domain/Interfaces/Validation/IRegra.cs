namespace CursoMVCAbril.Domain.Interfaces.Validation
{
    public interface IRegra<TEntity>
    {
        string MensagemErro { get; }
        bool Validar(TEntity entity);
    }
}
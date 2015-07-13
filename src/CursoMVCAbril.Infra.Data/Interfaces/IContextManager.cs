using CursoMVCAbril.Infra.Data.Context;

namespace CursoMVCAbril.Infra.Data.Interfaces
{
    public interface IContextManager
    {
        CursoMvcContext GetContext();
    }
}
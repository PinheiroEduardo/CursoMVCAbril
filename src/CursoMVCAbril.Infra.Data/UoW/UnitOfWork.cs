using System;
using CursoMVCAbril.Infra.Data.Context;
using CursoMVCAbril.Infra.Data.Interfaces;
using Microsoft.Practices.ServiceLocation;

namespace CursoMVCAbril.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CursoMvcContext _context;
        private readonly ContextManager _contextManager = ServiceLocator.Current.GetInstance<IContextManager>() as ContextManager;
        private bool _disposed;

        public UnitOfWork(CursoMvcContext context)
        {
            _context = _contextManager.GetContext();
        }
         
        public void BeginTransaction()
        {
            _disposed = false;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
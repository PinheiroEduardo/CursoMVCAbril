using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using CursoMVCAbril.Domain.Interfaces.Repository;
using CursoMVCAbril.Infra.Data.Context;
using CursoMVCAbril.Infra.Data.Interfaces;
using Microsoft.Practices.ServiceLocation;

namespace CursoMVCAbril.Infra.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly ContextManager _contextManager = ServiceLocator.Current.GetInstance<IContextManager>() as ContextManager;
        protected readonly CursoMvcContext Context;
        protected DbSet<TEntity> DbSet;

        public BaseRepository()
        {
            Context = _contextManager.GetContext();
            DbSet = Context.Set<TEntity>();
        }

        public virtual void Add(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public virtual TEntity GetById(Guid id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public virtual void Update(TEntity obj)
        {
            var entry = Context.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
        }

        public virtual void Remove(TEntity obj)
        {
            DbSet.Remove(obj);
        }

        public virtual IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        public virtual void Dispose()
        {
            Context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
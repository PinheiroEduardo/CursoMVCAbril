﻿namespace CursoMVCAbril.Infra.Data.Interfaces
{
    public interface IUnitOfWork
    {
        void BeginTransaction();

        void SaveChanges();
    }
}
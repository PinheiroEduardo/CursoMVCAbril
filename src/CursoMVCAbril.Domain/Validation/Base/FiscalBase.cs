﻿using System.Collections.Generic;
using CursoMVCAbril.Domain.Interfaces.Validation;
using CursoMVCAbril.Domain.ValueObjects;

namespace CursoMVCAbril.Domain.Validation.Base
{
    public abstract class FiscalBase<TEntity> : IFiscal<TEntity> where TEntity : class 
    {
        private readonly Dictionary<string, IRegra<TEntity>> _validations = new Dictionary<string, IRegra<TEntity>>();

        protected virtual void AdicionarRegra(string nomeRegra, IRegra<TEntity> rule)
        {
            _validations.Add(nomeRegra, rule);
        }

        protected void RemoverRegra(string nomeRegra)
        {
            _validations.Remove(nomeRegra);
        }

        public ValidationResult Validar(TEntity entity)
        {
            var result = new ValidationResult();
            foreach (var x in _validations.Keys)
            {
                var rule = _validations[x];
                if (!rule.Validar(entity))
                {
                    result.AdicionarErro(new ValidationError(rule.MensagemErro));
                }
            }
            return result;
        }

        protected IRegra<TEntity> ObterRegra(string nomeRegra)
        {
            IRegra<TEntity> rule;
            _validations.TryGetValue(nomeRegra, out rule);
            return rule;
        } 
    }
}
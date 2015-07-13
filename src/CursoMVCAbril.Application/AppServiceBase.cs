using CursoMVCAbril.Application.Validation;
using CursoMVCAbril.Domain.ValueObjects;
using CursoMVCAbril.Infra.Data.Interfaces;
using Microsoft.Practices.ServiceLocation;

namespace CursoMVCAbril.Application
{
    public class AppServiceBase
    {
        private IUnitOfWork _uow;

        public void BeginTransaction()
        {
            _uow = ServiceLocator.Current.GetInstance<IUnitOfWork>();
            _uow.BeginTransaction();
        }

        public void Commit()
        {
            _uow.SaveChanges(); 
        }

        protected ValidationAppResult DomainToApplicationResult(ValidationResult result)
        {
            var validationAppRresult = new ValidationAppResult();
            foreach (var validationError in result.Errors)
            {
                validationAppRresult.Erros.Add(new ValidationAppError(validationError.Message));
            }
            validationAppRresult.IsValid = result.IsValid;
            return validationAppRresult;
        }
    }
}
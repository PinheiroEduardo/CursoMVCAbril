using CursoMVCAbril.Application;
using CursoMVCAbril.Application.Interface;
using CursoMVCAbril.Domain.Interfaces.Repository;
using CursoMVCAbril.Domain.Interfaces.Repository.ReadOnly;
using CursoMVCAbril.Domain.Interfaces.Services;
using CursoMVCAbril.Domain.Services;
using CursoMVCAbril.Infra.Data.Context;
using CursoMVCAbril.Infra.Data.Interfaces;
using CursoMVCAbril.Infra.Data.Repositories;
using CursoMVCAbril.Infra.Data.Repositories.ReadOnly;
using CursoMVCAbril.Infra.Data.UoW;
using Ninject.Modules;

namespace CursoMVCAbril.Infra.CrossCutting.IoC
{
    public class NinjectModulo : NinjectModule
    {
        public override void Load()
        {
            //App
            Bind<IClienteAppService>().To<ClienteAppService>();

            //Domain Service
            Bind<IClienteService>().To<ClienteService>();

            //data
            Bind(typeof (IBaseRepository<>)).To(typeof (BaseRepository<>));
            Bind<IClienteRepository>().To<ClienteRepository>();
            Bind<IEnderecoRepository>().To<EnderecoRepository>();

            //data ReadOnly
            Bind<IClienteReadOnlyRepository>().To<ClienteReadOnlyRepository>();

            //data config
            Bind<IContextManager>().To<ContextManager>();
            Bind<IUnitOfWork>().To<UnitOfWork>();
        }
    }
}
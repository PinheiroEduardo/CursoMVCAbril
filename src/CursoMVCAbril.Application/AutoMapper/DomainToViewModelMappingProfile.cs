using AutoMapper;
using CursoMVCAbril.Application.ViewModels;
using CursoMVCAbril.Domain.Entities;

namespace CursoMVCAbril.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Cliente, ClienteViewModel>();
            Mapper.CreateMap<Endereco, EnderecoViewModel>();
            Mapper.CreateMap<Cliente, ClienteEnderecoViewModel>();
            Mapper.CreateMap<Endereco, ClienteEnderecoViewModel>();
        }
    }
}
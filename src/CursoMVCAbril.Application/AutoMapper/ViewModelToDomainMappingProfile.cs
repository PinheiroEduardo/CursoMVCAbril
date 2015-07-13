using AutoMapper;
using CursoMVCAbril.Application.ViewModels;
using CursoMVCAbril.Domain.Entities;

namespace CursoMVCAbril.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<EnderecoViewModel, Endereco>();
            Mapper.CreateMap<ClienteEnderecoViewModel, Cliente>();
            Mapper.CreateMap<ClienteEnderecoViewModel, Endereco>();
        }
    }
}
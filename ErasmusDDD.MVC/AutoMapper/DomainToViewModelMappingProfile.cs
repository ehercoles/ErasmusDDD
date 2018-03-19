using AutoMapper;
using ErasmusDDD.Domain.Entities;
using ErasmusDDD.MVC.ViewModels;

namespace ErasmusDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Livro, LivroVM>();
        }
    }
}
using AutoMapper;
using ErasmusDDD.Domain.Entities;
using ErasmusDDD.MVC.ViewModels;

namespace ErasmusDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<LivroVM, Livro>();
        }
    }
}
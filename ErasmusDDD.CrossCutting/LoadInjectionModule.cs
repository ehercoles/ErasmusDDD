using ErasmusDDD.Application;
using ErasmusDDD.Application.Interface;
using ErasmusDDD.Data.Repo;
using ErasmusDDD.Domain.Interfaces.Repos;
using ErasmusDDD.Domain.Interfaces.Services;
using ErasmusDDD.Domain.Services;
using Ninject.Modules;

namespace ErasmusDDD.CrossCutting
{
    public class LoadInjectionModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            Bind<ILivroAppService>().To<LivroAppService>();

            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            Bind<ILivroService>().To<LivroService>();

            Bind(typeof(IRepoBase<>)).To(typeof(RepoBase<>));
            Bind<ILivroRepo>().To<LivroRepo>();
        }
    }
}

using Autofac;
using Autofac.Integration.Mvc;
using MovieCRUD.Data;
using MovieCRUD.Data.Services;
using System.Reflection;
using System.Web.Mvc;

namespace MovieCRUD.App_Start
{
    public class ContainerConfig
    {
        public static void RegisterContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetAssembly(typeof(MvcApplication)));

            builder.RegisterType<Repository<Movie>>()
                .AsImplementedInterfaces()
                .InstancePerRequest();
            builder.RegisterType<ApplicationDbContext>()
                .AsSelf()
                .InstancePerRequest();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
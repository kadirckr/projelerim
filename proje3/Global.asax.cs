using Autofac;
using Autofac.Integration.Mvc;
using proje3.Data;
using proje3.Data.Repositories;
using proje3.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace proje3
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
           

            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            //  builder.RegisterType<denemeEntities>().AsSelf()
            //.As<DbContext>().InstancePerLifetimeScope();

            //builder.Register(c => new Repository<User>(new denemeEntities())).As<IRepository<User>>().InstancePerRequest();
            builder.Register(c => new UserRepository(new denemeEntities())).As<IUserRepository>().InstancePerRequest();


            //builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerRequest();
            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //AreaRegistration.RegisterAllAreas();
            //RouteConfig.RegisterRoutes(RouteTable.Routes);


            //var builder = new ContainerBuilder();
            //builder.RegisterType<Repository<User>>().As<IRepository<User>>();

            //var container = builder.Build();
            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}

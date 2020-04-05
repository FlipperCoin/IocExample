using System;
using Autofac;
using IocExample.Core;

namespace IocExample.Autofac
{
    class Program
    {
        static void Main(string[] args)
        {
            var containerBuilder = new ContainerBuilder();

            RegisterComponents(containerBuilder);

            var container = containerBuilder.Build();

            var productWriter = container.Resolve<IProductWriter>();
        }

        private static void RegisterComponents(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<RawJsonFormat>()
                .As<IJsonFormat>();
            containerBuilder.RegisterType<JsonSerializer>()
                .As<ISerializer>();

            containerBuilder.RegisterType<ProductWriter>()
                .As<IProductWriter>();
        }
    }
}

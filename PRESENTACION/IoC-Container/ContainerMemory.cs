using _01_APLICACION;
using Autofac;
using _02_DOMINIO.Repositorio;
using _03_INFRAESTRUCTURA;

namespace _00_PRESENTACION.IoC_Container
{
   static public class ContainerMemory
    {
        static public IContainer GetContainer()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<ClienteRepositorioEnMemoria>().As<ClienteRepositorio>().SingleInstance();
            builder.RegisterType<CrearCliente>();
            builder.RegisterType<ObtenerClientes>();
            IContainer container = builder.Build();

            return container;
        }
    }
}

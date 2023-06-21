using APLICACION;
using Autofac;
using DOMINIO.Repositorio;
using INFRAESTRUCTURA;


namespace PRESENTACION.IoC_Container
{
   static public class ContainerMemory
    {
        static public IContainer getContainer()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<ClienteRepositorioEnMemoria>().As<ClienteRepositorio>().SingleInstance();
            builder.RegisterType<CrearCliente>();
            builder.RegisterType<ObtenerUsuarios>();
            IContainer container = builder.Build();

            return container;
        }
    }
}

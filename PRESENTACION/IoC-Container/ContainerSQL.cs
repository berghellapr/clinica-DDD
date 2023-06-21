using APLICACION;
using Autofac;
using DOMINIO.Repositorio;
using INFRAESTRUCTURA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRESENTACION.IoC_Container
{
   public class ContainerSQL
    {
        static public IContainer getContainer()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<ClienteRepositorioSQL>().As<ClienteRepositorio>().SingleInstance();
            builder.RegisterType<CrearCliente>();
            builder.RegisterType<ObtenerUsuarios>();
            IContainer container = builder.Build();

            return container;
        }
    }
}

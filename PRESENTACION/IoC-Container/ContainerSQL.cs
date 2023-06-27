using _01_APLICACION;
using Autofac;
using _02_DOMINIO.Repositorio;
using _03_INFRAESTRUCTURA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_PRESENTACION.IoC_Container
{
   public class ContainerSQL
    {
        static public IContainer GetContainer()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<ClienteRepositorioSQL>().As<ClienteRepositorio>().SingleInstance();
            builder.RegisterType<CrearCliente>();
            builder.RegisterType<ObtenerClientes>();
            IContainer container = builder.Build();

            return container;
        }
    }
}

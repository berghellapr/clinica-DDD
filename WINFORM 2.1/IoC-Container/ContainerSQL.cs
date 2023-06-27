using _01_APLICACION;
using _02_DOMINIO.Repositorio;
using _03_INFRAESTRUCTURA;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WINFORM_2._1.IoC_Container
{
    public class ContainerSQL
    {
        static public IContainer GetContainer()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<ClienteRepositorioSQL>().As<ClienteRepositorio>().SingleInstance();
            builder.RegisterType<CrearCliente>();
            builder.RegisterType<ObtenerClientes>();
            builder.RegisterType<EliminarCliente>();
            IContainer container = builder.Build();

            return container;
        }
    }
}

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
    public class ContainerMongoDB
    {
        static public IContainer getContainer()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<ClienteRepositorioMongoDb>().As<ClienteRepositorio>().SingleInstance();
            builder.RegisterType<CrearCliente>();
            builder.RegisterType<ObtenerUsuarios>();
            IContainer container = builder.Build();
            return container;
        }
    }
}

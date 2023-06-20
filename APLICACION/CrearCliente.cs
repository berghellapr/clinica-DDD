using APLICACION.DTO;
using DOMINIO.Entidades;
using DOMINIO.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APLICACION
{
   public class CrearCliente
    {
        private ClienteRepositorio repositorio;

        public CrearCliente(ClienteRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public void ejecutar(ClienteDTO usuario)
        {
            this.repositorio.grabar(new Cliente(usuario.Id(), usuario.Nombre(), usuario.Apellido(), usuario.Email()));
        }
    }
}

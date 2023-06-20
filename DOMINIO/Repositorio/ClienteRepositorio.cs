using DOMINIO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO.Repositorio
{
    public interface ClienteRepositorio
    {
        public List<Cliente> obtenerTodos();
        public void grabar(Cliente cliente);
        public void EliminarCliente(Guid idCliente);
    }
}

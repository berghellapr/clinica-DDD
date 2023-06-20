using DOMINIO.Entidades;
using DOMINIO.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRAESTRUCTURA
{
    public class ClienteRepositorioEnMemoria : ClienteRepositorio
    {
        public void EliminarCliente(Guid idCliente)
        {
            throw new NotImplementedException();
        }

        private List<Cliente> clientes = new List<Cliente>();
        public void grabar(Cliente cliente)
        {
            this.clientes.Add(cliente);
        }

        public List<Cliente> obtenerTodos()
        {
            return this.clientes;
        }
    }
}

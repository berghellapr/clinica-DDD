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
    public class ObtenerUsuarios
    {
        private ClienteRepositorio repositorio;

        public ObtenerUsuarios(ClienteRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public List<ClienteDTO> ejecutar()
        {
            List<Cliente> clientes = this.repositorio.obtenerTodos();
            List<ClienteDTO> clientesDTO = new List<ClienteDTO>();
            foreach (Cliente cliente in clientes)
            {
                ClienteDTO clienteDTO = new ClienteDTO(cliente.Id(), cliente.Nombre(), cliente.Apellido(), cliente.Email());
                clientesDTO.Add(clienteDTO);
            }
            return clientesDTO;
        }
    }
}

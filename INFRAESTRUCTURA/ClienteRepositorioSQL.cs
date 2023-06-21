using DOMINIO.Entidades;
using DOMINIO.Repositorio;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRAESTRUCTURA
{
    public class ClienteRepositorioSQL : ClienteRepositorio
    {
        String connectionString = "";
        public void EliminarCliente(Guid idCliente)
        {
            throw new NotImplementedException();
        }

        public void grabar(Cliente cliente)
        {
            using(SqlConnection conexion = new SqlConnection(this.connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand("INSERT INTO usuarios (id, nombre, apellido, email) VALUES (@id, @nombre, @apellido, @email)", conexion))
                {
                    comando.Parameters.Add("@id", System.Data.SqlDbType.UniqueIdentifier).Value = cliente.Id();
                    comando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = cliente.Nombre();
                    comando.Parameters.Add("@apellido", System.Data.SqlDbType.VarChar).Value = cliente.Apellido();
                    comando.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = cliente.Email();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public List<Cliente> obtenerTodos()
        {
                List<Cliente> clientes = new List<Cliente>();
                using (SqlConnection conexion = new SqlConnection(this.connectionString))
                {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand("SELECT id, nombre, apellido, email FROM Clientes", conexion))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Guid id = reader.GetGuid(0);
                            String nombre = reader.GetString(1);
                            String apellido = reader.GetString(2);
                            String email = reader.GetString(3);
                            Cliente cliente = new Cliente(id, nombre, apellido, email);
                            clientes.Add(cliente);
                        }
                    }
                }
            }

            return clientes;
        }
    }
}

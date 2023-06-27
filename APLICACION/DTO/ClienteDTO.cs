using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_APLICACION.DTO
{
    public class ClienteDTO
    {
        private Guid id;
        private String nombre;
        private String apellido;
        private String email;

        public ClienteDTO(Guid id, String nombre, String apellido, String email)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
        }

        public Guid Id()
        {
            return this.id;
        }
        public String Nombre()
        {
            return this.nombre;
        }
        public String Apellido()
        {
            return this.apellido;
        }
        public String Email()
        {
            return this.email;
        }

        public String Presentacion()
        {
            return "Mi nombre es " + this.nombre +
                   ", mi apellido es " + this.apellido +
                   " y mi email es " + this.email;
        }

    }
}

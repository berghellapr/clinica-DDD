using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APLICACION.DTO
{
    public class ClienteDTO
    {
        private Guid id;
        private String nombre;
        private String apellido;
        //private int dni;
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

        public String presentacion()
        {
            return "Mi nombre es  " + this.nombre +
                   " Mi apellido es  " + this.apellido +
                   " Mi Email es  " + this.email;
        }

    }
}

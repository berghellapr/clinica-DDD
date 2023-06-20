using DOMINIO.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO.Entidades
{
    //IdUnico, Nombre, Apellidos, DNI, Teléfono o Email.
    //chequear validación mail, obvio no lo pusiste para que no explote.
    public class Cliente
    {
        private Identificador id;
        private Nombre nombre;
        private Apellido apellido;
        //private Dni dni;
        private Email email;

        public Cliente(Guid id, String nombre, String apellido, String email)
        {
            this.id = new Identificador(id);
            this.nombre = new Nombre(nombre);
            this.apellido = new Apellido(apellido);
            this.email = new Email(email);
        }

        public Guid Id()
        {
            return this.id.Valor();
        }
        public String Nombre()
        {
            return this.nombre.Valor();
        }
        public String Apellido()
        {
            return this.apellido.Valor();
        }
        public String Email()
        {
            return this.email.Valor();
        }
        public void cambiarNombre(String nuevoNombre)
        {
            this.nombre = new Nombre(nuevoNombre);
        }

        public String presentacion()
        {
            return "Mi nombre es " + this.nombre.Valor() +
                   "Mi apellido es " + this.apellido.Valor() +
                   "Mi Email es " + this.email.Valor();
        }
    }
}

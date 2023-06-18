using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO.ValueObject
{
    internal class Dni
    {
        private int valor;

        public Dni(int valor)
        {
            this.DebeContener8Numeros(valor);
            this.valor = valor;
        }
        public int Valor()
        {
            return this.valor;
        }
        private void DebeContener8Numeros(int valor)
        {
            String valorString = valor.ToString();

            if (valorString.Length == 0 || valorString.Length < 8 ) 
            {
                throw new Exception("El DNI debe contener 8 digitos");
            }
        }
    }
}

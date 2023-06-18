using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO.ValueObject
{
    public class Apellido
    {
            private String valor;

            public Apellido(String valor)
            {
                this.DebeContenerMasDe4Caracteres(valor);
                this.valor = valor;
            }
            public String Valor()
            {
                return this.valor;
            }
            private void DebeContenerMasDe4Caracteres(String valor)
            {
                if (valor.Length < 4)
                {
                    throw new Exception("El nombre debe contener, al menos, 4 caractreres");
                }
            }
        }
}

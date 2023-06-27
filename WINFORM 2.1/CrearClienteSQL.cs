using _01_APLICACION;
using _01_APLICACION.DTO;
using Autofac;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WINFORM_2._1.IoC_Container;

namespace WINFORM_2._1
{
    public partial class CrearClienteSQL : Form
    {

        Autofac.IContainer container = ContainerSQL.GetContainer();
        public CrearClienteSQL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CrearCliente crear = container.Resolve<CrearCliente>();
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            String email = txtEmail.Text;
            crear.Ejecutar(new ClienteDTO(Guid.NewGuid(), nombre, apellido, email));
            this.Close();
        }


    }
}

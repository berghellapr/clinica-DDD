using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WINFORM_2._1
{
    public partial class SQLForm : Form
    {
        public SQLForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OpenCrearCliente();
        }

        private void OpenCrearCliente()
        {
            CrearClienteSQL crearCliente = new CrearClienteSQL();
            crearCliente.ShowDialog();
        }
    }
}

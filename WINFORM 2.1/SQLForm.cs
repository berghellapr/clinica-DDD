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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WINFORM_2._1
{
    public partial class SQLForm : Form
    {
        public SQLForm()
        {
            InitializeComponent();
            LlenarDataGrid();
        }

        Autofac.IContainer container = ContainerSQL.GetContainer();


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OpenCrearCliente();
            LlenarDataGrid();
        }

        private void OpenCrearCliente()
        {
            CrearClienteSQL crearCliente = new CrearClienteSQL();
            crearCliente.ShowDialog();
        }

        private void LlenarDataGrid()
        {
            try
            {
                gridClientes.Rows.Clear();
                ObtenerClientes obtenedorClientes = container.Resolve<ObtenerClientes>();
                List<ClienteDTO> clienteDTOs = obtenedorClientes.Ejecutar();
                foreach (ClienteDTO cliente in clienteDTOs)
                {
                    int rowIndex = gridClientes.Rows.Add();
                    DataGridViewRow row = gridClientes.Rows[rowIndex];
                    row.Cells[0].Value = cliente.Id();
                    row.Cells[1].Value = cliente.Nombre();
                    row.Cells[2].Value = cliente.Apellido();
                    row.Cells[3].Value = cliente.Email();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                EliminarCliente eliminar = container.Resolve<EliminarCliente>();
                Guid id = new Guid(gridClientes.CurrentRow.Cells[0].Value.ToString());
                eliminar.Ejecutar(id);
                LlenarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Seleccione una fila", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

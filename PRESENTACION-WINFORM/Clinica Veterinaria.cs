using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION_WINFORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            OpenSQLForm();
            this.Close();
        }

        private void OpenSQLForm()
        {
            SQLForm sqlForm = new SQLForm();
            sqlForm.ShowDialog();
        }
    }
}

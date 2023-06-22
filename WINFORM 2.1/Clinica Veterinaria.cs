namespace WINFORM_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void OpenSQLForm()
        {
            SQLForm sqlForm = new SQLForm();
            sqlForm.ShowDialog();
        }

        private void BtnSQL_Click_1(object sender, EventArgs e)
        {
            OpenSQLForm();
            this.Close();
        }
    }
}
namespace MHD_DB
{
    public partial class Form1 : Form
    {
        dbConnection DBconnection = new dbConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddRegister_Click(object sender, EventArgs e)
        {
            FormAddRegister formAddRegister = new FormAddRegister();
            formAddRegister.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DBconnection.GetData();
        }
    }
}
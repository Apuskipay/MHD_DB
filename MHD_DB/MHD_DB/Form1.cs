namespace MHD_DB
{
    public partial class Form1 : Form
    {
        dbConnection DBconnection = new dbConnection();
        public Form1()
        {
            InitializeComponent();
            btnDisconnect.Enabled = false;
            btnAddRegister.Enabled = false;
            btnSearch.Enabled = false;
            btnEditRegister.Enabled = false;
            TBsearch.Enabled = false;
            clbSearch.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            DBconnection.Connect();
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
            btnAddRegister.Enabled = true;
            btnSearch.Enabled = true;
            TBsearch.Enabled = true;
            clbSearch.Enabled = true;
            btnEditRegister.Enabled = true;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            DBconnection.Disconnect();
            btnDisconnect.Enabled = false;
            btnAddRegister.Enabled = false;
            btnSearch.Enabled = false;
            btnEditRegister.Enabled = false;
            TBsearch.Enabled = false;
            clbSearch.Enabled = false;
            btnConnect.Enabled = true;
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
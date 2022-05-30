namespace MHD_DB
{
    public partial class Form1 : Form
    {
        dbConnection conn = new dbConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            conn.Connect();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            conn.Disconnect();
        }
    }
}
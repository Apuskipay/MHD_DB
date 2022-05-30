using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace MHD_DB
{
    public class dbConnection
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id= postgres; Password = J313185264d; Database = MHD_DB");
        public void Connect()
        {
            conn.Open();
            MessageBox.Show("Conexión exitosa!");
        }

        public void Disconnect()
        {
            conn.Close();
            MessageBox.Show("Desconexión exitosa!");
        }
        
    }
}

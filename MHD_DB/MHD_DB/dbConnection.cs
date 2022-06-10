using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace MHD_DB
{
    public class dbConnection
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id= postgres; Password = J313185264d; Database = MHD_DB_SIMPLE");
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

        public DataTable GetData()
        {
            string query = "SELECT * FROM public.\"Objeto\"";
            NpgsqlCommand connection = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(connection);
            DataTable table = new DataTable();
            data.Fill(table);

            return table;
        }
        public DataTable GetData(string searchParameter)
        {
            string query = "select * from \"Objeto\" where \"codigo_objeto\" = ";
            NpgsqlCommand connection = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(connection);
            DataTable table = new DataTable();
            data.Fill(table);

            return table;
        }
       
    }
}

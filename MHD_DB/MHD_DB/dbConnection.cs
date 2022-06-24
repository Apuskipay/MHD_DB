using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace MHD_DB
{
    //TEST COMMENT
    public class dbConnection
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id= postgres; Password = J313185264d; Database = MHD_DB_SIMPLE");
        public void Connect()
        {
            //Opens connection with the database
            conn.Open();
            MessageBox.Show("Conexión exitosa!");
        }

        public void Disconnect()
        {
            //Closes connection with the database
            conn.Close();
            MessageBox.Show("Desconexión exitosa!");
        }
        public void Insert(
            //Informacion General
            string codigoObjeto, 
            string otrosCodigos, 
            string tipoObjeto, 
            string descripcion, 
            string material,
            string procedencia,
            string cultura,
            string epoca,
            string estilo,
            string listaRoja,
            string movimientos,
            string estado_conservacion,
            string observaciones,
            string bibliografia,
            //Ubicacion
            string ubicacionActual,
            string piso,
            string ambito,
            string vitrina,
            string nombreDeposito,
            string numDeposito,
            string numContenedor,
            //Dimensiones
            double altoVal,
            string altoUni,
            double anchoVal,
            string anchoUni,
            double largoVal,
            string Largouni,
            double espVal,
            string espUni,
            double ejeMayorVal,
            string ejeMayorUni,
            double ejeMenorVal,
            string ejeMenorUni,
            double pesoVal,
            string pesoUni,
            //Documentacion Fotografica
            string codigoFoto1,
            string codigoFoto2,
            string codigoFoto3,
            string codigoFoto4,
            string codigoFoto5,
            string codigoFoto6,
            string dirFoto1,
            string dirFoto2,
            string dirFoto3,
            string dirFoto4,
            string dirFoto5,
            string dirFoto6,
            //Informacion de Registro
            string inventariadoPor,
            string fechaInvenariado,
            string fotografiadoPor,
            string fechaFotografiado,
            string digitadoPor,
            string fechaDigitado
            )
        {
            //Inserts a new row into the Objeto table
            string query = "Insert into \"Objeto\" values ('"
                //Informacion General
                + codigoObjeto + "','"
                + otrosCodigos + "','"
                + tipoObjeto + "','"
                + descripcion + "','"
                + material + "','"
                + procedencia + "','"
                + cultura + "','"
                + epoca + "','"
                + estilo + "','"
                + listaRoja + "','"
                + movimientos + "','"
                + estado_conservacion + "','"
                + observaciones + "','"
                + bibliografia + "','"
                //Ubicacion
                + ubicacionActual + "','"
                + piso + "','"
                + ambito + "','"
                + vitrina + "','"
                + nombreDeposito + "','"
                + numDeposito + "','"
                + numContenedor + "',"
                //Dimensiones
                + altoVal + ",'"
                + altoUni + "',"
                + anchoVal + ",'"
                + anchoUni + "',"
                + largoVal + ",'"
                + Largouni + "',"
                + espVal + ",'"
                + espUni + "',"
                + ejeMayorVal + ",'"
                + ejeMayorUni + "',"
                + ejeMenorVal + ",'"
                + ejeMenorUni + "',"
                + pesoVal + ",'"
                + pesoUni + "','"
                //Documentacion Fotografica
                + codigoFoto1 + "','"
                + codigoFoto2 + "','"
                + codigoFoto3 + "','"
                + codigoFoto4 + "','"
                + codigoFoto5 + "','"
                + codigoFoto6 + "','"
                + dirFoto1 + "','"
                + dirFoto2 + "','"
                + dirFoto3 + "','"
                + dirFoto4 + "','"
                + dirFoto5 + "','"
                + dirFoto6 + "','"
                //Informacion de Registro
                + inventariadoPor + "','"
                + fechaInvenariado + "','"
                + fotografiadoPor + "','"
                + fechaFotografiado + "','"
                + digitadoPor + "','"
                + fechaDigitado + "')";

            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand(query, conn);
            command.ExecuteNonQuery();
            MessageBox.Show("Registro añadido satisfactoriamente!");
            conn.Close();

        }

        public DataTable GetData()
        {
            conn.Open();
            //Gets the data from the Objeto Table
            string query = "SELECT * FROM public.\"Objeto\"";
            NpgsqlCommand connection = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(connection);
            DataTable table = new DataTable();
            data.Fill(table);
            conn.Close();
            return table;
        }
        public DataTable GetData(string searchParameter)
        {
            conn.Open();
            //Gets the row that coincides with the given code.
            string query = "select * from \"Objeto\" where \"codigo_objeto\" = ";
            NpgsqlCommand connection = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(connection);
            DataTable table = new DataTable();
            data.Fill(table);
            conn.Close();
            return table;
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHD_DB
{
    public partial class FormAddRegister : Form
    {
        dbConnection DBconnection = new dbConnection();
        public FormAddRegister()
        {
            InitializeComponent();
            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;
            pictureBox3.AllowDrop = true;
            pictureBox4.AllowDrop = true;
            pictureBox5.AllowDrop = true;
            pictureBox6.AllowDrop = true;
        }
        
        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string pic in ((string[])e.Data.GetData(DataFormats.FileDrop)))
            {
                Image img = Image.FromFile(pic);
                pictureBox1.Image = img;
            }
        }


        private void FormAddRegister_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string pic in ((string[])e.Data.GetData(DataFormats.FileDrop)))
            {
                Image img = Image.FromFile(pic);
                pictureBox2.Image = img;
            }
        }

        private void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox3_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string pic in ((string[])e.Data.GetData(DataFormats.FileDrop)))
            {
                Image img = Image.FromFile(pic);
                pictureBox3.Image = img;
            }
        }

        private void pictureBox3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox4_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string pic in ((string[])e.Data.GetData(DataFormats.FileDrop)))
            {
                Image img = Image.FromFile(pic);
                pictureBox4.Image = img;
            }
        }

        private void pictureBox4_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox5_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string pic in ((string[])e.Data.GetData(DataFormats.FileDrop)))
            {
                Image img = Image.FromFile(pic);
                pictureBox5.Image = img;
            }
        }

        private void pictureBox5_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox6_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string pic in ((string[])e.Data.GetData(DataFormats.FileDrop)))
            {
                Image img = Image.FromFile(pic);
                pictureBox6.Image = img;
            }
        }

        private void pictureBox6_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void btnRegistrarObjeto_Click(object sender, EventArgs e)
        {
            //Sends the data as parameters
            DBconnection.Insert(
                tbCodigo_Objeto.Text,
                tbOtrosCodigos.Text,
                tbTipo_Objeto.Text,
                tbDescripcion.Text,
                tbMaterial.Text,
                tbProcedencia.Text,
                tbCultura.Text,
                tbEpoca.Text,
                tbEstilo.Text,
                cbListaRoja.Text,
                tbMovimientos.Text,
                cbConservacion.Text,
                tbObservacion.Text,
                tbBibliografia.Text,
                cbUbicacionActual.Text,
                tbPiso.Text,
                tbAmbito.Text,
                tbVitrina.Text,
                cbDeposito.Text,
                tbNumeroDeposito.Text,
                tbNumeroContenedor.Text,
                Convert.ToDouble(tbAltoVal.Text),
                cbAltoUni.Text,
                Convert.ToDouble(tbAnchoVal.Text),
                cbAnchoUni.Text,
                Convert.ToDouble(tbLargoVal.Text),
                cbLargoUni.Text,
                Convert.ToDouble(tbEspVal.Text),
                cbEspUni.Text,
                Convert.ToDouble(tbEjeMayorVal.Text),
                cbEjeMayorUni.Text,
                Convert.ToDouble(tbEjeMenorVal.Text),
                cbEjeMenorUni.Text,
                Convert.ToDouble(tbPesoVal.Text),
                cbPesoUni.Text,
                tbCodFot1.Text,
                tbCodFot2.Text,
                tbCodFot3.Text,
                tbCodFot4.Text,
                tbCodFot5.Text,
                tbCodFot6.Text,
                "user/MHD_DB/DOC_FOT/" + tbCodigo_Objeto + "/" + tbCodFot1.Text + ".jpeg",
                "user/MHD_DB/DOC_FOT/" + tbCodigo_Objeto + "/" + tbCodFot2.Text + ".jpeg",
                "user/MHD_DB/DOC_FOT/" + tbCodigo_Objeto + "/" + tbCodFot3.Text + ".jpeg",
                "user/MHD_DB/DOC_FOT/" + tbCodigo_Objeto + "/" + tbCodFot4.Text + ".jpeg",
                "user/MHD_DB/DOC_FOT/" + tbCodigo_Objeto + "/" + tbCodFot5.Text + ".jpeg",
                "user/MHD_DB/DOC_FOT/" + tbCodigo_Objeto + "/" + tbCodFot6.Text + ".jpeg",
                tbInventariadoPor.Text,
                mcFechaInventario.Text,
                tbFotografiadoPor.Text,
                mcFechaFotografia.Text,
                tbDigitadoPor.Text,
                mcFechaDigitacion.Text);
                

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }
    }
}

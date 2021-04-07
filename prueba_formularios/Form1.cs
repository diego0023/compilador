using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba_formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
        
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Archivo.InitialDirectory = "C:/";
            if (Archivo.ShowDialog()== DialogResult.OK)
            {
                this.txtDireccion.Text = Archivo.FileName;
            }

            System.IO.StreamReader sr = new System.IO.StreamReader(txtDireccion.Text,System.Text.Encoding.Default);

            string contenido;
            
            contenido = sr.ReadToEnd();
            sr.Close();
            txtContenido.Text = contenido;

        }
    }
}

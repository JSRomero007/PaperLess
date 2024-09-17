using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperLess
{
    public partial class Main : Form
    {
        private Start _formPrincipal; // Referencia al Form1

        public Main(Start formPrincipal)
        {
            InitializeComponent();
            _formPrincipal = formPrincipal; // Almacena la referencia de Form1
        }

        private void Main_Load(object sender, EventArgs e)
        {
            panel2.Visible= false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MenuAll f1 = new MenuAll(_formPrincipal);

            // Llamar al método para cargar el formulario en el panel
            _formPrincipal.CargarFormularioEnPanel(f1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Login form2 = new Login();
            form2.Show();
            _formPrincipal.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            panel2.Visible=false;
            string rutaImagen = @"C:\\Users\\JICR\\OneDrive\\Documentos\\001_Projects\\004_PaperLess\\Images\\vm.png";
            pictureBox5.Image = Image.FromFile(rutaImagen);

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            string rutaImagen = @"C:\\Users\\JICR\\OneDrive\\Documentos\\001_Projects\\004_PaperLess\\Images\\Tesla.png";
            pictureBox5.Image = Image.FromFile(rutaImagen);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            string rutaImagen = @"C:\\Users\\JICR\\OneDrive\\Documentos\\001_Projects\\004_PaperLess\\Images\\bmw.png";
            pictureBox5.Image = Image.FromFile(rutaImagen);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new Main(this));
        }
        public void CargarFormularioEnPanel(Form formulario)
        {
            MainPanel.Controls.Clear(); // Limpiar el contenido actual del panel
            formulario.TopLevel = false; // El formulario no será de nivel superior
            formulario.FormBorderStyle = FormBorderStyle.None; // Quitar bordes del formulario
            formulario.Dock = DockStyle.Fill; // Ajustar al tamaño del panel
            MainPanel.Controls.Add(formulario); // Agregar el formulario al panel
            formulario.Show(); // Mostrar el formulario dentro del panel
        }
            private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

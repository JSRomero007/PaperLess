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
    public partial class MenuAll : Form
    {
        private Start _formPrincipal;
        public MenuAll(Start formPrincipal)
        {
            InitializeComponent();
            _formPrincipal = formPrincipal;
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            GotoView("Criterio 43");
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            GotoView("Instrucciones de trabajo estandarizado");
        }
        public void GotoView(string text)
        {
            
            ViewPdf f1 = new ViewPdf(_formPrincipal,text);

            // Llamar al método para cargar el formulario en el panel
            _formPrincipal.CargarFormularioEnPanel(f1);
        }
        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            GotoView("14 Principios básicos");
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            GotoView("Plan de reacción de MFQ");
        }

        private void rjButton6_Click(object sender, EventArgs e)
        {
            GotoView("Plan de reacción de MFO");
        }

        private void rjButton7_Click(object sender, EventArgs e)
        {
            GotoView("Plan de reacción de MFP");
        }

        private void rjButton8_Click(object sender, EventArgs e)
        {
            GotoView("Stop signs");
        }

        private void rjButton10_Click(object sender, EventArgs e)
        {
            GotoView("Políticas …");
        }

        private void rjButton11_Click(object sender, EventArgs e)
        {
            GotoView("Criterio de aceptación y rechazo");
        }

        private void rjButton12_Click(object sender, EventArgs e)
        {
            GotoView("Alertas de calidad");
        }

        private void rjButton13_Click(object sender, EventArgs e)
        {
            GotoView("Checker to check");
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            Main f1 = new Main(_formPrincipal);

            // Llamar al método para cargar el formulario en el panel
            _formPrincipal.CargarFormularioEnPanel(f1);
        }
    }
}

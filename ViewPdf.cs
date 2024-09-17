using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;

namespace PaperLess
{
    public partial class ViewPdf : Form
    {
        private Start _formPrincipal; 
        private string _texto; 

        // Constructor que acepta una referencia al formulario principal
        public ViewPdf(Start formPrincipal, string texto)
        {
            InitializeComponent();
            CrearYPdfVisualizar();
            _formPrincipal = formPrincipal;
            _texto = texto; // Almacenar el texto recibido

            // Asumiendo que tienes una Label llamada label1 en ViewPdf, puedes establecer el texto así:
            label1.Text = _texto;
        }

        private void ViewPdf_Load(object sender, EventArgs e)
        {
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            MenuAll f1 = new MenuAll(_formPrincipal);

            // Llamar al método para cargar el formulario en el panel
            _formPrincipal.CargarFormularioEnPanel(f1);
        }
        private void CrearYPdfVisualizar()
        {
            // Crear un documento PDF
            PdfDocument pdf = new PdfDocument();
            pdf.Info.Title = "Documento PDFsharp";

            // Agregar una página
            PdfPage page = pdf.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 20);

            // Mostrar el PDF en el WebBrowser
            webBrowser1.Navigate(@"file:///" + Uri.EscapeUriString(@"C:/Users/JICR/OneDrive/Documentos/001_Projects/004_PaperLess/PDF/1.pdf"));

        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea8
{
    public partial class MascotaYDueno : Form
    {
        public MascotaYDueno()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Dueno mascotas = new Dueno();

            int edad = Convert.ToInt32(EdadTextBox.Text);
            int telefono = Convert.ToInt32(TelefonoTextBox.Text);
            int edadPerro = Convert.ToInt32(EdadPerroTextBox.Text);

            Dueno mascotas1 = new Dueno("nombre", "apellido", edad, "direccion", telefono, "nombrePerro", "resa", edadPerro);

            string nombre = Convert.ToString(NombreTextBox.Text);
            string apellido = Convert.ToString(ApellidoTextBox.Text);
            string direccion = Convert.ToString(DireccionTextBox.Text);
            string nombrePerro = Convert.ToString(NombrePeroTextBox.Text);
            string rasa = Convert.ToString(RasaTextBox.Text);
            
            InformacionDataGridView.Rows.Add(NombreTextBox.Text, ApellidoTextBox.Text, EdadTextBox, DireccionTextBox.Text, TelefonoTextBox.Text, NombrePeroTextBox.Text, RasaTextBox.Text, EdadPerroTextBox.Text);
        }
    }
}

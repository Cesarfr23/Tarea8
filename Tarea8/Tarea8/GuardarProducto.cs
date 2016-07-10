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
    public partial class GuardarProducto : Form
    {
        public GuardarProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassGuardarProducto[] producto = new ClassGuardarProducto[5];
            producto[1].nombreProducto = "";
            producto[2].proveedor = "";
            producto[3].marcaProducto = "";

            string nombreProducto = Convert.ToString(NombreTextBox.Text);
            string proveedor = Convert.ToString(ProveedorTextBox.Text);
            string marcaProducto = Convert.ToString(MarcaTextBox.Text);

            GuardarGridView.Rows.Add(NombreTextBox.Text, ProveedorTextBox.Text, MarcaTextBox.Text);

        }
    }
}

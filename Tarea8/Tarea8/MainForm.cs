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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void estructuraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarProducto guadarProducto = new GuardarProducto();
            guadarProducto.MdiParent = this;
            guadarProducto.Show();
        }

        private void estructuraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CuentaBancaria cuentaBancaria = new CuentaBancaria();
            cuentaBancaria.MdiParent = this;
            cuentaBancaria.Show();
        }

        private void estructuraToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MascotaYDueno mascotaYDueno = new MascotaYDueno();
            mascotaYDueno.MdiParent = this;
            mascotaYDueno.Show();
        }

        private void estructuraToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TiposNeumaticos tiposNeumaticos = new TiposNeumaticos();
            tiposNeumaticos.MdiParent = this;
            tiposNeumaticos.Show();
        }

        private void estructuraToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            TipoEstrellas tipoEstrellas = new TipoEstrellas();
            tipoEstrellas.MdiParent = this;
            tipoEstrellas.Show();
        }
    }
}

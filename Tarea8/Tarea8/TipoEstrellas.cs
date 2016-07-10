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
    public partial class TipoEstrellas : Form
    {
        public TipoEstrellas()
        {
            InitializeComponent();
        }

        public enum TiposEstrella
        {
            Estrella_Sol, Estrella_Gigante_Roja, Nibelosa_Planetaria, Enana_Blanca, Estrella_Neutrones
        }

        private void TipoButton_Click(object sender, EventArgs e)
        {
            TiposEstrella tipo1 = (TiposEstrella)0;
            TiposEstrella tipo2 = (TiposEstrella)1;
            TiposEstrella tipo3 = (TiposEstrella)2;
            TiposEstrella tipo4 = (TiposEstrella)3;
            TiposEstrella tipo5 = (TiposEstrella)4;

            TipoEstrellasListBox.Items.Add(tipo1);
            TipoEstrellasListBox.Items.Add(tipo2);
            TipoEstrellasListBox.Items.Add(tipo3);
            TipoEstrellasListBox.Items.Add(tipo4);
            TipoEstrellasListBox.Items.Add(tipo5);
        }
    }
}

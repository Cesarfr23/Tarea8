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
    public partial class TiposNeumaticos : Form
    {
        public TiposNeumaticos()
        {
            InitializeComponent();
        }

        public enum TiposNeumatico
        {
            Todo_Terreno, Tradicionales, Asimetricos, Lisos, Para_Nieve
        }
       
        private void TiposButton_Click(object sender, EventArgs e)
        {
            TiposNeumatico tipo = (TiposNeumatico)1;
            TiposNeumatico tipo1 = (TiposNeumatico)2;
            TiposNeumatico tipo2 = (TiposNeumatico)3;
            TiposNeumatico tipo3 = (TiposNeumatico)4;
            TiposNeumatico tipo4 = (TiposNeumatico)5;
            TiposNeumatico tipo5 = (TiposNeumatico)6;

            TiposListBox.Items.Add(tipo);
            TiposListBox.Items.Add(tipo1);
            TiposListBox.Items.Add(tipo2);
            TiposListBox.Items.Add(tipo3);
            TiposListBox.Items.Add(tipo4);
            TiposListBox.Items.Add(tipo5);
        }
    }
}

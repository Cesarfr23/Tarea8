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
    public partial class CuentaBancaria : Form
    {
        public CuentaBancaria()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            ClassCuentaBancaria[] Cuenta = new ClassCuentaBancaria[10];
            Cuenta[1].codigo = 0;
            Cuenta[2].cuenta = "";
            Cuenta[3].nombreTitula = "";
            Cuenta[4].saldo = 0;
            Cuenta[5].banco = "";
            Cuenta[6].moneda = "";

            int codigo = Convert.ToInt32(CodigoTextBox.Text);
            string cuenta = Convert.ToString(CuentaTextBox.Text);
            string nombreTitular = Convert.ToString(NombreTextBox.Text);
            float saldo = Convert.ToSingle(SaldoTextBox.Text);
            string banco = Convert.ToString(BancoTextBox.Text);
            string moneda = Convert.ToString(MonedaTextBox.Text);

            InformacionDataGridView.Rows.Add(CodigoTextBox.Text, CuentaTextBox.Text, NombreTextBox.Text, SaldoTextBox.Text, BancoTextBox.Text, MonedaTextBox.Text);
        }
    }
}

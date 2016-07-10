using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea8
{
    public struct ClassCuentaBancaria
    {
        public int codigo;
        public string cuenta;
        public string nombreTitula;
        public float saldo;
        public string banco;
        public string moneda;

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("codigo: {0}, cuenta: {1}, nombreTitular: {2}, saldo: {3}, banco: {4}, moneda: {5}, codigo, cuenta, nombreTitular, saldo, banco, moneda");
            return (stringBuilder.ToString());
        }
    }
}

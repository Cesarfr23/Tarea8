using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea8
{
    
    public struct GurdarProducto
    {
            public string nombreProducto;
            public string proveedor;
            public string marcaProducto;

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendFormat("nombreProducto: {0}, proveedor: {1}, marcaProducto: {2}, nombreProducto, proveedor, marcaProducto");

            return (stringBuilder.ToString());
        }
    }
}

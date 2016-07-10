using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea8
{
    public struct Mascota
    {
        string nombrePerro;
        string rasa;
        int edadPerro;

        public Mascota(string nombrep, string rasap, int edadp)
        {
            nombrePerro = nombrep;
            rasa = rasap;
            edadPerro = edadp;
        }

        public override string ToString()
        {
            StringBuilder stringBuiler = new StringBuilder();
                stringBuiler.AppendFormat("Mascota: {0}, {1}, #{2}", nombrePerro, rasa, edadPerro);
            return (stringBuiler.ToString());
        }
    }

    public struct Dueno
    {
        string nombre;
        string apellido;
        int edad;
        string direccion;
        int telefono;
        public Mascota mascota;

        public Dueno(string nombreD, string apellidoD, int edadD, string direccionD, int telefonoD, string nombrep, string rasap, int edadp)
        {
            nombre = nombreD;
            apellido = apellidoD;
            edad = edadD;
            direccion = direccionD;
            telefono = telefonoD;

            mascota = new Mascota(nombrep, rasap, edadp);
        }

        public override string ToString()
        {
            StringBuilder stringBuiler = new StringBuilder();
            stringBuiler.AppendFormat("nombre: {0}, apellido: {1}, edad: {2}, direccion: {3}, telefono: {4}", nombre, apellido, edad, direccion, telefono);

            stringBuiler.Append(mascota.ToString());
            return (stringBuiler.ToString());
        }
    }
}

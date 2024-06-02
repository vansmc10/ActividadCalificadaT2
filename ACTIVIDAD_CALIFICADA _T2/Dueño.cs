using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVIDAD_CALIFICADA__T2
{
    public class Dueño
    {
        public string T_Nombre { get; set; }
        public string T_Direccion { get; set; }
        public string T_Telefono { get; set; }


        public Dueño()
        { 
        }
        public Dueño(string nombre, string direccion, string telefono)
        {
            T_Nombre = nombre;
            T_Direccion = direccion;
            T_Telefono = telefono;
        }
        override
        public  string ToString()
        {
            
            return T_Nombre;
        }
    }
}

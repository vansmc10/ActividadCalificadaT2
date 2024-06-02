using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVIDAD_CALIFICADA__T2
{
    public class Mascota
    {
        public string T_Nombre { get; set; }
        public int T_Edad { get; set; }
        public string T_Raza { get; set; }
        public Dueño T_Dueño { get; set; }


        public Mascota(string nombre, int edad, string raza, Dueño dueño)
        {
            T_Nombre = nombre;
            T_Edad = edad;
            T_Raza = raza;
            T_Dueño = dueño;
        }


    }
}

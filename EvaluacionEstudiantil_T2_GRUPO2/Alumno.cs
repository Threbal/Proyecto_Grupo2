using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionEstudiantil_T2_GRUPO2
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Codigo { get; set; }
        public string Curso { get; set; }

        public override string ToString()
        {
            return $"{Apellidos}, {Nombre} ({Codigo})";
        }
    }

}

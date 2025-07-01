using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionEstudiantil_T2_GRUPO2
{
    public class Asistencia
    {
        public Alumno Alumno { get; set; }
        public DateTime Fecha { get; set; }
        public bool Presente { get; set; }

        public override string ToString()
        {
            string estado = Presente ? "Presente" : "Ausente";
            return $"{Fecha.ToShortDateString()} - {Alumno.Apellidos}, {Alumno.Nombre}: {estado}";
        }
    }


}

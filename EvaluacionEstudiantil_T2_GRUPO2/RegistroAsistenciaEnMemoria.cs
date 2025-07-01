using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionEstudiantil_T2_GRUPO2
{
    public class RegistroAsistenciaEnMemoria : IRegistroAsistencia
    {
        private readonly List<Asistencia> _asistencias = new List<Asistencia>();

        public void RegistrarAsistencia(Asistencia asistencia)
        {
            _asistencias.Add(asistencia);
        }

        public List<Asistencia> ObtenerAsistencias()
        {
            return new List<Asistencia>(_asistencias); // Devuelve una copia para evitar modificaciones externas
        }
    }
}

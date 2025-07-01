using System.Collections.Generic;
using System.Linq;
using SOLID_StudentPerformanceApp.Models;

namespace SOLID_StudentPerformanceApp.Strategies
{
    public class EstrategiaPromedioSimple : IEstrategiaCalculo
    {
        public double Calculate(List<Evaluacion> evaluaciones)
        {
            return evaluaciones.Average(e => e.Nota);
        }
    }
}
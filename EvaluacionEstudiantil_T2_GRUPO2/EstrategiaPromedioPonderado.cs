using System.Collections.Generic;
using System.Linq;
using SOLID_StudentPerformanceApp.Models;

namespace SOLID_StudentPerformanceApp.Strategies
{
    public class EstrategiaPromedioPonderado : IEstrategiaCalculo
    {
        public double Calculate(List<Evaluacion> evaluaciones)
        {
            double totalNota = evaluaciones.Sum(e => e.Nota * e.Peso);
            double totalPeso = evaluaciones.Sum(e => e.Peso);
            return totalPeso == 0 ? 0 : totalNota / totalPeso;
        }
    }
}
using System.Collections.Generic;
using SOLID_StudentPerformanceApp.Models;

namespace SOLID_StudentPerformanceApp.Strategies
{
    public interface IEstrategiaCalculo
    {
        double Calculate(List<Evaluacion> evaluaciones);
    }
}
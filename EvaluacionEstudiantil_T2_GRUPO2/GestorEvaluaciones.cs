using System.Collections.Generic;
using SOLID_StudentPerformanceApp.Models;
using SOLID_StudentPerformanceApp.Strategies;

namespace SOLID_StudentPerformanceApp.Managers
{
    public class GestorEvaluaciones
    {
        private readonly List<Evaluacion> evaluaciones = new();
        private readonly IEstrategiaCalculo calculationStrategy;

        public GestorEvaluaciones(IEstrategiaCalculo estrategia)
        {
            calculationStrategy = estrategia;
        }

        public void AddEvaluation(Evaluacion eval)
        {
            evaluaciones.Add(eval);
        }

        public double GetPerformance()
        {
            return calculationStrategy.Calculate(evaluaciones);
        }

        public List<Evaluacion> GetEvaluations()
        {
            return evaluaciones;
        }
    }
}
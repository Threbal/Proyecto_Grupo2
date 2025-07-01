using System.Windows.Forms;

namespace SOLID_StudentPerformanceApp.Reports
{
    public class GeneradorReporteConsola : IGeneradorReporte
    {
        public void Generate(string studentName, double rendimiento)
        {
            MessageBox.Show($"Estudiante: {studentName}\nRendimiento: {rendimiento:F2}");
        }
    }
}
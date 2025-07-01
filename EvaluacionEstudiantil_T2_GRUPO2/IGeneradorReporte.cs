namespace SOLID_StudentPerformanceApp.Reports
{
    public interface IGeneradorReporte
    {
        void Generate(string studentName, double rendimiento);
    }
}
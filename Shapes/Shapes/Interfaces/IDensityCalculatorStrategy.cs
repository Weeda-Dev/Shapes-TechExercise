namespace Shapes.Interfaces
{ 
    public interface IDensityCalculatorStrategy
    {
        double CalcDensity(double mass, double height, double length, double width);
    }
}
namespace SpecFlowCalculator;

public class Calculator
{
    public double FirstNumber { get; set; }
    public double SecondNumber { get; set; }

    public double Add()
    {
        return FirstNumber + SecondNumber;
    }

    public double Subtract()
    {
        return FirstNumber - SecondNumber;
    }

    public double Multiply()
    {
        return FirstNumber * SecondNumber;
    }

    public double Divide()
    {
        return (double)FirstNumber / (double)SecondNumber;
    }

    public double SquareRoot()
    {
        return FirstNumber != 0 ? Math.Round(Math.Sqrt(FirstNumber), 2) : 0;
    }

    public double Modulo()
    {
        return FirstNumber % SecondNumber;
    }

    public double Floor()
    {
        return Math.Floor(FirstNumber);
    }

    public double Ceiling()
    {
        return Math.Ceiling(FirstNumber);
    }
}
using System;

class Calculator
{
    public int Add(int a, int b) { return a + b; }


    public double Add(double a, double b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero");
        }
        return a / b;
    }

    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero");
        }
        return a / b;
    }
}

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();


        // Примеры использования
        Console.WriteLine(calculator.Add(5, 3));
        Console.WriteLine(calculator.Add(5.5, 3.6));

        Console.WriteLine(calculator.Subtract(10, 4));
        Console.WriteLine(calculator.Subtract(10.5, 4.2));

        Console.WriteLine(calculator.Multiply(2, 3));
        Console.WriteLine(calculator.Multiply(2.5, 3.7));

        Console.WriteLine(calculator.Divide(6, 2));
        Console.WriteLine(calculator.Divide(6.4, 2.0));
    }
}
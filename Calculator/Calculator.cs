namespace Calculator;

public static class Calculator
{
    public static double Add(double X, double Y)
    {
        return X + Y;
    }

    public static double Divide(double X, double Y)
    {
        if (Y != 0)
        {
            return X / Y;
        }
        else {
            throw new DivideByZeroException();
        }
    }

}


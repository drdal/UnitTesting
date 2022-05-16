using System;
using Xunit;

namespace Calculator.Tests;

public class CalculatorTests
{
    //[Fact]
    //public void Add_SimpleValueShouldCalculate()
    //{
    //    // Arrange
    //    double expected = 4;

    //    // Act
    //    double actual = Calculator.Add_SimpleValueShouldCalculate(2, 2);

    //    // Assert
    //    Assert.Equal(expected, actual);
    //}

    [Theory]
    [InlineData(21, 5.25, 26.25)]
    [InlineData(2, 2, 4)]
    [InlineData(double.MaxValue, 5, double.MaxValue)]
    public void Add_SimpleValueShouldCalculate(double X, double Y, double expected)
    {
        // Arrange

        // Act
        double actual = Calculator.Add(X, Y);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(8, 4, 2)]
    public void Divide_SimpleValueShouldCalculate(double X, double Y, double expected)
    {
        // Arrange

        // Act
        double actual = Calculator.Divide(X, Y);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Divide_ByZeroShouldFail()
    {
        // Arrange
        double X = 15;
        double Y = 0;

        // Act


        // Assert
        Assert.Throws<DivideByZeroException>(() => Calculator.Divide(X, Y));
    }

}

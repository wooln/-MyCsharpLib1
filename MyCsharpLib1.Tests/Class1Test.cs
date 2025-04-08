using JetBrains.Annotations;
using MyCsharpLib1;
using Xunit;

namespace MyCsharpLib1.Tests;

[TestSubject(typeof(Class1))]
public class Class1Test
{
    [Fact]
    public void Add_ShouldReturnSumOfTwoNumbers()
    {
        // Arrange
        int a = 5;
        int b = 3;

        // Act
        int result = Class1.Add(a, b);

        // Assert
        Assert.Equal(8, result);
    }

    [Fact]
    public void Subtract_ShouldReturnDifferenceOfTwoNumbers()
    {
        // Arrange
        int a = 5;
        int b = 3;

        // Act
        int result = Class1.Subtract(a, b);

        // Assert
        Assert.Equal(2, result);
    }
}
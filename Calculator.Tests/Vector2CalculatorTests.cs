using FluentAssertions;

namespace Calculator.Tests;

public class Vector2CalculatorTests
{
    private Vector2Calculator _calculator;

    [SetUp]
    public void Setup()
    {
        _calculator = new Vector2Calculator();
    }

    [TestCase(1, 1, 2, 3, 3, 4)]
    [TestCase(0, 0, 0, 0, 0, 0)]
    public void Vector2Calculator_Add_ReturnVector2(int leftX, int leftY, int rightX, int rightY, int expectedX, int expectedY)
    {
        Vector2 left = new Vector2(leftX, leftY);
        Vector2 right = new Vector2(rightX, rightY);
        Vector2 expected = new Vector2(expectedX, expectedY);

        Vector2 result = _calculator.Add(left, right);

        result.Should().NotBeNull();
        result.Should().BeOfType<Vector2>();
        result.Should().BeEquivalentTo(expected);
    }
    
    [Test]
    public void Vector2Calculator_Add_ReturnVector2()
    {
        Vector2 left = new Vector2(1, 1);
        Vector2 right = new Vector2(2, 3);
        Vector2 expected = new Vector2(-1, -2);

        Vector2 result = _calculator.Substract(left, right);

        result.Should().NotBeNull();
        result.Should().BeOfType<Vector2>();
        result.Should().BeEquivalentTo(expected);
    } 
}
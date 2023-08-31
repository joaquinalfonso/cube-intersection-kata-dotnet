using CubeIntersection.Domain;
using CubeIntersection.Domain.Shape;

namespace CubeIntersection.Tests.Domain;

/// <summary>
/// Test methods to validate the creation of a rectangular prism with positive size and handle cases with zero or negative sizes.
/// </summary>
public class RectangularPrismCreationTests {

    [Theory]
    [InlineData(1, 1, 1)]
    [InlineData(1.5, 1.5, 1.5)]
    public void When_CreateRectangularPrismWithPositiveDimensions_ThenOK
                    (double length, double width, double height) {
        //Arrange
        var position = new Coordinates(0f, 0f, 0f);
        //Act
        var cube = new RectangularPrism(position, length, width, height);
        //Assert
        cube.Should().NotBeNull();
    }

    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(0, 0, 1)]
    [InlineData(0, 1, 0)]
    [InlineData(1, 0, 0)]
    public void When_CreateRectangularPrismWithZeroDimension_ThenRaiseArgumentException
                    (double length, double width, double height) {
        //Arrange
        var position = new Coordinates(0f, 0f, 0f);
        //Act
        var act = () => new RectangularPrism(position, length, width, height);
        //Assert
        act.Should().Throw<ArgumentException>();
    }

    [Theory]
    [InlineData(1, 1, -1)]
    [InlineData(1, -1, 1)]
    [InlineData(-1, 1, 1)]
    [InlineData(-1.5, 1, 1)]
    public void When_CreateRectangularPrismWithNegactiveDimension_ThenRaiseArgumentException
                    (double length, double width, double height) {
        //Arrange
        var position = new Coordinates(0f, 0f, 0f);
        //Act
        var act = () => new RectangularPrism(position, length, width, height);
        //Assert
        act.Should().Throw<ArgumentException>();
    }
}

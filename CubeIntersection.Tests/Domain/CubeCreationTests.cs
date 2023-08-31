using CubeIntersection.Domain;
using CubeIntersection.Domain.Shape;

namespace CubeIntersection.Tests.Domain;

/// <summary>
/// Test methods to validate the creation of a cube with positive size and handle cases with zero or negative sizes.
/// </summary>
public class CubeCreationTests {

    [Theory]
    [InlineData(1)]
    [InlineData(1.5)]
    public void When_CreateCubeWithPositiveSize_Then_IsCreated(double sideLength) {
        //Arrange
        var position = new Coordinates(0f, 0f, 0f);
        //Act
        var cube = new Cube(position, sideLength);
        //Assert
        cube.Should().NotBeNull();
    }

    [Fact]
    public void When_CreateCubeWithZeroSize_Then_RaiseArgumentException() {
        //Arrange
        var position = new Coordinates(0f, 0f, 0f);
        //Act
        var act = () => new Cube(position, 0);
        //Assert
        act.Should().Throw<ArgumentException>();
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(-1.5)]
    public void When_CreateCubeWithNegativeSize_Then_RaiseArgumentException(double sideLength) {
        //Arrange
        var position = new Coordinates(0f, 0f, 0f);
        //Act
        var act = () => new Cube(position, sideLength);
        //Assert
        act.Should().Throw<ArgumentException>();
    }
}

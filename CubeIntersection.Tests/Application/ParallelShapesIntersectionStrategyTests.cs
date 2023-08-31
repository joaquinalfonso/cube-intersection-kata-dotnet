using CubeIntersection.Application;
using CubeIntersection.Domain;
using CubeIntersection.Domain.Shape;

namespace CubeIntersection.Tests.Application;

/// <summary>
/// Test methods to verify the exception handling of the "ParallelShapesIntersectionStrategy" class when dealing with null input shapes.
/// </summary>
public class ParallelShapesIntersectionStrategyTests {

    [Fact]
    public void When_CalculateIntersectionOfNulls_Then_RaiseArgumentNullException() {
        //Arrange
        var parallelShapesIntersectionStrategy = new ParallelShapesIntersectionStrategy();
        //Act
        var act = () => parallelShapesIntersectionStrategy.CalculateIntersectionVolume(null, null);

        //Assert
        act.Should().Throw<ArgumentNullException>();
    }

    [Fact]
    public void When_CalculateIntersectionOfCubeAndNull_Then_RaiseArgumentNullException() {
        //Arrange
        var parallelShapesIntersectionStrategy = new ParallelShapesIntersectionStrategy();
        var cube = new Cube(new Coordinates(0, 0, 0), 10);
        //Act
        var act = () => parallelShapesIntersectionStrategy.CalculateIntersectionVolume(cube, null);

        //Assert
        act.Should().Throw<ArgumentNullException>();
    }

    [Fact]
    public void When_CalculateIntersectionOfNullAndCube_Then_RaiseArgumentNullException() {
        //Arrange
        var parallelShapesIntersectionStrategy = new ParallelShapesIntersectionStrategy();
        var cube = new Cube(new Coordinates(0, 0, 0), 10);
        //Act
        var act = () => parallelShapesIntersectionStrategy.CalculateIntersectionVolume(null, cube);

        //Assert
        act.Should().Throw<ArgumentNullException>();
    }
}

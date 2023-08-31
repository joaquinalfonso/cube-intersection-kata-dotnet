using CubeIntersection.Application;
using CubeIntersection.Domain;
using CubeIntersection.Domain.Shape;

namespace CubeIntersection.Tests.Application;

/// <summary>
/// Test methods to validate the intersection volume calculation between non-intersecting axis-aligned cubes.
/// </summary>
public class IntersectionServiceParallelsShapesNoCollideTests {
    [Theory]
    [InlineData(0, 0, 0, 2, 3, 3, 3, 2)]
    [InlineData(0, 0, 0, 2, 3, 0, 0, 2)]
    [InlineData(0, 0, 0, 2, 0, 3, 0, 2)]
    [InlineData(0, 0, 0, 2, 0, 0, 3, 2)]
    public void When_CalculateIntersectionOfCubesThatNotIntersectInAxis_Then_VolumeIs0
                    (double x1, double y1, double z1, double sizeLength1,
                     double x2, double y2, double z2, double sizeLength2) {
        //Arrange
        var parallelShapesIntersectionStrategy = new ParallelShapesIntersectionStrategy();
        var rotatedShapesIntersectionStrategy = new RotatedShapesIntersectionStrategy();
        var intersectionService = new IntersectionService(parallelShapesIntersectionStrategy, rotatedShapesIntersectionStrategy);
        
        var cube1 = new Cube(new Coordinates(x1, y1, z1), sizeLength1);
        var cube2 = new Cube(new Coordinates(x2, y2, z2), sizeLength2);

        //Act
        var intersectionVolume = intersectionService.CalculateIntersectionVolume(cube1, cube2);

        //Assert
        intersectionVolume.Should().Be(0);
    }

    [Fact]
    public void When_CalculateIntersectionOfNulls_Then_RaiseArgumentNullException() {
        //Arrange
        var parallelShapesIntersectionStrategy = new ParallelShapesIntersectionStrategy();
        var rotatedShapesIntersectionStrategy = new RotatedShapesIntersectionStrategy();
        var intersectionService = new IntersectionService(parallelShapesIntersectionStrategy, rotatedShapesIntersectionStrategy);

        //Act
        var act = () => intersectionService.CalculateIntersectionVolume(null, null);

        //Assert
        act.Should().Throw<ArgumentNullException>();
    }

    [Fact]
    public void When_CalculateIntersectionOfCubeAndNull_Then_RaiseArgumentNullException() {
        //Arrange
        var parallelShapesIntersectionStrategy = new ParallelShapesIntersectionStrategy();
        var rotatedShapesIntersectionStrategy = new RotatedShapesIntersectionStrategy();
        var intersectionService = new IntersectionService(parallelShapesIntersectionStrategy, rotatedShapesIntersectionStrategy);
        
        var cube = new Cube(new Coordinates(0, 0, 0), 10);

        //Act
        var act = () => intersectionService.CalculateIntersectionVolume(cube, null);

        //Assert
        act.Should().Throw<ArgumentNullException>();
    }

    [Fact]
    public void When_CalculateIntersectionOfNullAndCube_Then_RaiseArgumentNullException() {
        //Arrange
        var parallelShapesIntersectionStrategy = new ParallelShapesIntersectionStrategy();
        var rotatedShapesIntersectionStrategy = new RotatedShapesIntersectionStrategy();
        var intersectionService = new IntersectionService(parallelShapesIntersectionStrategy, rotatedShapesIntersectionStrategy);

        var cube = new Cube(new Coordinates(0, 0, 0), 10);

        //Act
        var act = () => intersectionService.CalculateIntersectionVolume(null, cube);

        //Assert
        act.Should().Throw<ArgumentNullException>();
    }
}
using CubeIntersection.Application;
using CubeIntersection.Domain;
using CubeIntersection.Domain.Shape;

namespace CubeIntersection.Tests.Application;

/// <summary>
/// Test methods to validate the intersection volume calculation between rotated cubes. (Not implemented)
/// </summary>
public class IntersectionServiceRotatedShapesTests {

    [Theory]
    [InlineData(0, 0, 0, 2, false, 0, 0, 0, 2, false)]
    [InlineData(0, 0, 0, 2, false, 0, 0, 0, 2, true)]
    [InlineData(0, 0, 0, 2, true, 0, 0, 0, 2, false)]

    public void When_CalculateIntersectionOfRotatedCubes_Then_RaiseNotImplementedException
                    (double x1, double y1, double z1, double sizeLength1, bool axisAligned1,
                     double x2, double y2, double z2, double sizeLength2, bool axisAligned2) {
        //Arrange
        var parallelShapesIntersectionStrategy = new ParallelShapesIntersectionStrategy();
        var rotatedShapesIntersectionStrategy = new RotatedShapesIntersectionStrategy();
        var intersectionService = new IntersectionService(parallelShapesIntersectionStrategy, rotatedShapesIntersectionStrategy);

        var cube1 = new Cube(new Coordinates(x1, y1, z1), sizeLength1);
        cube1.IsAxisAligned = axisAligned1;
        var cube2 = new Cube(new Coordinates(x2, y2, z2), sizeLength2);
        cube2.IsAxisAligned = axisAligned2;

        //Act
        var act = () => intersectionService.CalculateIntersectionVolume(cube1, cube2);

        //Assert
        act.Should().Throw<NotImplementedException>();
    }
}

using CubeIntersection.Application;
using CubeIntersection.Domain;
using CubeIntersection.Domain.Shape;

namespace CubeIntersection.Tests.Application;

/// <summary>
/// Test methods to validate the intersection volume calculation between intersecting axis-aligned cubes.
/// </summary>
public class IntersectionServiceParallelsShapesWithCollideTests {

    [Theory]
    [InlineData(0, 0, 0, 2, 1, 1, 1, 2, 1)]
    [InlineData(1, 1, 1, 2, 0, 0, 0, 2, 1)]
    public void When_CalculateIntersectionOfCubesOfSameSizesThatIntersectPartially_Then_VolumeIsCalculated
                    (double x1, double y1, double z1, double sizeLength1,
                     double x2, double y2, double z2, double sizeLength2,
                     double volume) {
        //Arrange
        var parallelShapesIntersectionStrategy = new ParallelShapesIntersectionStrategy();
        var rotatedShapesIntersectionStrategy = new RotatedShapesIntersectionStrategy();
        var intersectionService = new IntersectionService(parallelShapesIntersectionStrategy, rotatedShapesIntersectionStrategy);

        var cube1 = new Cube(new Coordinates(x1, y1, z1), sizeLength1);
        var cube2 = new Cube(new Coordinates(x2, y2, z2), sizeLength2);

        //Act
        var intersectionVolume = intersectionService.CalculateIntersectionVolume(cube1, cube2);

        //Assert
        intersectionVolume.Should().Be(volume);
    }

    [Theory]
    [InlineData(0, 0, 0, 4, 2, 2, 2, 2, 1)]
    [InlineData(0, 0, 0, 6, 2, 2, 2, 2, 8)]
    [InlineData(0, 0, 0, 8, 0, 0, 4, 4, 32)]
    [InlineData(0, 0, 0, 8, 0, 0, 0, 4, 64)]

    public void When_CalculateIntersectionOfCubesOfDiferentSizesThatIntersectPartially_Then_VolumeIsCalculated
                    (double x1, double y1, double z1, double sizeLength1,
                     double x2, double y2, double z2, double sizeLength2,
                     double volume) {
        //Arrange
        var parallelShapesIntersectionStrategy = new ParallelShapesIntersectionStrategy();
        var rotatedShapesIntersectionStrategy = new RotatedShapesIntersectionStrategy();
        var intersectionService = new IntersectionService(parallelShapesIntersectionStrategy, rotatedShapesIntersectionStrategy);

        var cube1 = new Cube(new Coordinates(x1, y1, z1), sizeLength1);
        var cube2 = new Cube(new Coordinates(x2, y2, z2), sizeLength2);

        //Act
        var intersectionVolume = intersectionService.CalculateIntersectionVolume(cube1, cube2);

        //Assert
        intersectionVolume.Should().Be(volume);
    }

    [Theory]
    [InlineData(0, 0, 0, 2, -1, -1, -1, 2, 1)]
    [InlineData(-1, -1, -1, 2, 0, 0, 0, 2, 1)]
    [InlineData(-1, -1, -1, 2, -2, -2, -2, 2, 1)]
    public void When_CalculateIntersectionThatIntersectPartiallyInNegegativeAxis_Then_VolumeIsCalculated
                    (double x1, double y1, double z1, double sizeLength1,
                     double x2, double y2, double z2, double sizeLength2,
                     double volume) {
        //Arrange
        var parallelShapesIntersectionStrategy = new ParallelShapesIntersectionStrategy();
        var rotatedShapesIntersectionStrategy = new RotatedShapesIntersectionStrategy();
        var intersectionService = new IntersectionService(parallelShapesIntersectionStrategy, rotatedShapesIntersectionStrategy);

        var cube1 = new Cube(new Coordinates(x1, y1, z1), sizeLength1);
        var cube2 = new Cube(new Coordinates(x2, y2, z2), sizeLength2);

        //Act
        var intersectionVolume = intersectionService.CalculateIntersectionVolume(cube1, cube2);

        //Assert
        intersectionVolume.Should().Be(volume);
    }

    [Theory]
    [InlineData(0, 0, 0, 1, 1)]
    [InlineData(0, 0, 0, 2, 8)]
    [InlineData(-1, -1, -1, 2, 8)]
    public void When_CalculateIntersectionOfSameCube_Then_VolumeIsCalculated
                    (double x1, double y1, double z1, double sizeLength1,
                     double volume) {
        //Arrange
        var parallelShapesIntersectionStrategy = new ParallelShapesIntersectionStrategy();
        var rotatedShapesIntersectionStrategy = new RotatedShapesIntersectionStrategy();
        var intersectionService = new IntersectionService(parallelShapesIntersectionStrategy, rotatedShapesIntersectionStrategy);

        var cube1 = new Cube(new Coordinates(x1, y1, z1), sizeLength1);

        //Act
        var intersectionVolume = intersectionService.CalculateIntersectionVolume(cube1, cube1);

        //Assert
        intersectionVolume.Should().Be(volume);
    }

    [Theory]
    [InlineData(0, 0, 0, 10, 3, 3, 3, 1, 1)]
    [InlineData(0, 0, 0, 10, 3, 3, 3, 2, 8)]
    [InlineData(0, 0, 0, 10, -3, -3, -3, 3, 27)]    
    public void When_CalculateIntersectionOfACubeInsideOtherCube_Then_VolumeIsCalculated
                    (double x1, double y1, double z1, double sizeLength1,
                     double x2, double y2, double z2, double sizeLength2,
                     double volume) {
        //Arrange
        var parallelShapesIntersectionStrategy = new ParallelShapesIntersectionStrategy();
        var rotatedShapesIntersectionStrategy = new RotatedShapesIntersectionStrategy();
        var intersectionService = new IntersectionService(parallelShapesIntersectionStrategy, rotatedShapesIntersectionStrategy);

        var cube1 = new Cube(new Coordinates(x1, y1, z1), sizeLength1);
        var cube2 = new Cube(new Coordinates(x2, y2, z2), sizeLength2);

        //Act
        var intersectionVolume = intersectionService.CalculateIntersectionVolume(cube1, cube2);

        //Assert
        intersectionVolume.Should().Be(volume);
    }
}
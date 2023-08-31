using CubeIntersection.Domain;
using CubeIntersection.Domain.Shape;

namespace CubeIntersection.Tests.Domain;

/// <summary>
/// Test methods to verify the volume calculation function for cubes with different sizes.
/// </summary>
public class CubeVolumeTests {

    [Theory]
    [InlineData(1, 1)]
    [InlineData(2, 8)]
    [InlineData(3, 27)]
    [InlineData(4, 64)]
    [InlineData(1.5, 3.375)]
    public void When_CalculateVolumeOfCube_Then_VolumeIsCalculated(double size, double volume) {
        //Arrange
        var cube = new Cube(new Coordinates(0f, 0f, 0f), size);

        //Act
        var calculatedVolume = cube.CalculateVolume();

        //Assert
        calculatedVolume.Should().Be(volume);
    }
}
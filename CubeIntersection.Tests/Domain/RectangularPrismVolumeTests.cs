using CubeIntersection.Domain;
using CubeIntersection.Domain.Shape;

namespace CubeIntersection.Tests.Domain;

/// <summary>
/// Test methods to verify the volume calculation function for rectangular prisms with different sizes.
/// </summary>
public class RectangularPrismVolumeTests {

    [Theory]
    [InlineData(1, 1, 1, 1)]
    [InlineData(2, 2, 1, 4)]
    [InlineData(2, 2, 2, 8)]
    [InlineData(3, 3, 3, 27)]
    [InlineData(1, 4, 4, 16)]
    [InlineData(4, 1, 4, 16)]
    [InlineData(4, 4, 1, 16)]
    [InlineData(4, 4, 4, 64)]
    [InlineData(1.5, 1.5, 1.5, 3.375)]
    public void When_CalculateVolumeOfRectangularPrism_Then_VolumeIsCalculated
                    (double length, double width, double height, double expectedVolume) {
        //Arrange
        var rectangularPrism = new RectangularPrism(new Coordinates(0f, 0f, 0f), length, width, height);

        //Act
        var calculatedVolume = rectangularPrism.CalculateVolume();

        //Assert
        calculatedVolume.Should().Be(expectedVolume);
    }
}
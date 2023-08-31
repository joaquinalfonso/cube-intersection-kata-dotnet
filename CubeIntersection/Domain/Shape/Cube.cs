namespace CubeIntersection.Domain.Shape;

/// <summary>
/// Cube class is a specific type of RectangularPrism that represents a cube in three-dimensional space. 
/// It initializes with equal side lengths to create a cube shape.
/// </summary>
public class Cube : RectangularPrism {
    public Cube(in Coordinates center, double sideLength) : base(center, sideLength, sideLength, sideLength) {

    }
}

namespace CubeIntersection.Domain;

/// <summary>
/// Represents a point in three-dimensional space
/// </summary>
public struct Coordinates {
    public double X { get; }
    public double Y { get; }
    public double Z { get; }

    public Coordinates(double x, double y, double z) {
        X = x;
        Y = y;
        Z = z;
    }

}

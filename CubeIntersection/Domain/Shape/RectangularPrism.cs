namespace CubeIntersection.Domain.Shape;

/// <summary>
/// Class that implements "IShape" representing a 3D rectangular prism with a specified center and dimensions. 
/// It calculates the volume based on length, width, and height.
/// </summary>
public class RectangularPrism : IShape {

    protected Coordinates _center;

    public double Length { get; protected set; }
    public double Width { get; protected set; }
    public double Height { get; protected set; }

    public bool IsAxisAligned { get; set; }

    public double MinX => _center.X - (Length / 2);
    public double MaxX => _center.X + (Length / 2);
    public double MinY => _center.Y - (Width / 2);
    public double MaxY => _center.Y + (Width / 2);
    public double MinZ => _center.Z - (Height / 2);
    public double MaxZ => _center.Z + (Height / 2);

    public RectangularPrism(in Coordinates center, double length, double width, double height) {

        if (length <= 0 || width <= 0 || height <= 0) {
            throw new ArgumentException("Dimensions cannot be negative.");
        }

        _center = center;
        Length = length;
        Width = width;
        Height = height;
        IsAxisAligned = true;
    }

    public double CalculateVolume() {
        return Length * Width * Height;
    }

}

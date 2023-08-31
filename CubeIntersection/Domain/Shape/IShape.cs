namespace CubeIntersection.Domain.Shape;

/// <summary>
/// Interface that defines properties and a method for geometric shapes, including volume calculation and boundary information in 3D space.
/// </summary>
public interface IShape {
    double Length { get; }
    double Width { get; }
    double Height { get; }
    bool IsAxisAligned { get; set; }
    double MinX { get; }
    double MaxX { get; }
    double MinY { get; }
    double MaxY { get; }
    double MinZ { get; }
    double MaxZ { get; }

    double CalculateVolume();
}

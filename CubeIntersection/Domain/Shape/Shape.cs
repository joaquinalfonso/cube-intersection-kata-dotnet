namespace CubeIntersection.Domain.Shape;
public abstract class Shape
{
    protected Coordinates _center;

    public double Length { get; protected set; }
    public double Width { get; protected set; }
    public double Height { get; protected set; }

    public bool IsAxisAligned { get; set; }

    public double Left => _center.X - (Length / 2);
    public double Right => _center.X + (Length / 2);
    public double Bottom => _center.Y - (Width / 2);
    public double Top => _center.Y + (Width / 2);
    public double Front => _center.Z - (Height / 2);
    public double Back => _center.Z + (Height / 2);

    public abstract double CalculateVolume();
   
}

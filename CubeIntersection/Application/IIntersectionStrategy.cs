using CubeIntersection.Domain.Shape;

namespace CubeIntersection.Application;
/// <summary>
/// Interface that defines a method to calculate the volume of intersection between two shapes.
/// Base for strategy pattern
/// </summary>
public interface IIntersectionStrategy {
    double CalculateIntersectionVolume(IShape shape1, IShape shape2);
}

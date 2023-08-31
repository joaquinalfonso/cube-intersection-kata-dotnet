using CubeIntersection.Domain.Shape;

namespace CubeIntersection.Application;

/// <summary>
/// Static class that provides a method to calculate the volume of intersection between two shapes using specific strategies.
/// </summary>
public class IntersectionService {

    private IIntersectionStrategy _parallelShapesIntersectionStrategy;
    private IIntersectionStrategy _rotatedShapesIntersectionStrategy;

    public IntersectionService(IIntersectionStrategy parallelShapesIntersectionStrategy, IIntersectionStrategy rotatedShapesIntersectionStrategy) {
        _parallelShapesIntersectionStrategy = parallelShapesIntersectionStrategy;
        _rotatedShapesIntersectionStrategy = rotatedShapesIntersectionStrategy;
    }

    public double CalculateIntersectionVolume(IShape shape1, IShape shape2) {

        if (shape1 == null || shape2 == null) {
            throw new ArgumentNullException();
        }

        IIntersectionStrategy strategy = ChooseIntersectionStrategy(shape1, shape2);
        return strategy.CalculateIntersectionVolume(shape1, shape2);
    }

    private IIntersectionStrategy ChooseIntersectionStrategy(IShape shape1, IShape shape2) {
        if (shape1.IsAxisAligned && shape2.IsAxisAligned) {
            return _parallelShapesIntersectionStrategy;
        }
        return _rotatedShapesIntersectionStrategy;
    }
}


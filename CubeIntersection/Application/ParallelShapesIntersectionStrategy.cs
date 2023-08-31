using CubeIntersection.Domain;
using CubeIntersection.Domain.Shape;

namespace CubeIntersection.Application;

/// <summary>
/// Class that implements the strategy to calculate the intersection volume of axis-aligned cubes.
/// </summary>
internal class ParallelShapesIntersectionStrategy : IIntersectionStrategy {

    private const float NO_INTERSECTION_VOLUME = 0;

    public double CalculateIntersectionVolume(IShape shape1, IShape shape2) {

        if (shape1 == null || shape2 == null) {
            throw new ArgumentNullException();
        }

        var intersectionLeft = Math.Max(shape1.MinX, shape2.MinX);
        var intersectionRight = Math.Min(shape1.MaxX, shape2.MaxX);
        var intersectionLength = intersectionRight - intersectionLeft;

        if (intersectionLength < 0) {
            // No intersection exists
            return NO_INTERSECTION_VOLUME;
        }

        var intersectionBottom = Math.Max(shape1.MinY, shape2.MinY);
        var intersectionTop = Math.Min(shape1.MaxY, shape2.MaxY);
        var intersectionWidth = intersectionTop - intersectionBottom;

        if (intersectionWidth < 0) {
            // No intersection exists
            return NO_INTERSECTION_VOLUME;
        }

        var intersectionFront = Math.Max(shape1.MinZ, shape2.MinZ);
        var intersectionBack = Math.Min(shape1.MaxZ, shape2.MaxZ);
        var intersectionHeight = intersectionBack - intersectionFront;

        if (intersectionHeight < 0) {
            // No intersection exists
            return NO_INTERSECTION_VOLUME;
        }

        var intersectionCenter = new Coordinates(x: intersectionLeft + (intersectionLength / 2),
                                                 y: intersectionBottom + (intersectionWidth / 2),
                                                 z: intersectionFront + (intersectionHeight / 2));

        var intersectionCube = new RectangularPrism(intersectionCenter, intersectionLength, intersectionWidth, intersectionHeight);

        return intersectionCube.CalculateVolume();
    }
}
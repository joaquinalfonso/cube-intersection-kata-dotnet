# Cube Intersection kata dotnet

![Build and test workflow](https://github.com/joaquinalfonso/cube-intersection-kata-dotnet/actions/workflows/dotnet.yml/badge.svg)

## Problem to solve
> Design and start and application (or test project) which accepts as input dimensions and coordinates of two cubic objects (considering a 3D space). 
>
> **The application must determine whether the two objects collide and calculate the intersected volume.**
>
> It's not a math exercise, so it is acceptable to consider the two cubes are parallel, so there is no rotation among themselves.
>The input coordinates define the center of the cube.
>
>The purpose of this exercise is to define the application design and architecture, focusing on the parts which ensure the correctness, performance and code clarity. Any design pattern is accepted and should be justified.


## Solution

The solution consists of two projects:

- ***CubeIntersection***: Class library that implements the desired functionality.
- ***CubeIntersection.Tests***: Test project to verify the proper operation of the class library. It also allows for safe code refactoring and Test-Driven Development (TDD).

**No application is implemented to use the class library; everything is validated through the test project.**

## Project Structure

- ***CubeIntersection***
    - ***Application***: Implements the use case of cube intersection and volume calculation.
    - ***Domain***: Implements the domain classes.
        - **RectangularPrism**: Class that implements "IShape" representing a 3D rectangular prism with a specified center and dimensions. The intersection of two cubes is a rectangular prism.
        - **Cube**: Cube class is a specific type of RectangularPrism that represents a cube in three-dimensional space.
        - **IShape**: Interface that defines properties and a method for geometric shapes, including volume calculation and boundary information in 3D space.
- ***CubeIntersection.Tests***
    - ***Application***: Tests for the application layer.
    - ***Domain***: Tests for the domain layer.

## Best Practices and Design Patterns

- The solution has been developed following the principles of *SOLID*, *Clean Code*, and *Domain-Driven Design (DDD)*.
- Inheritance relationship defined between the domain classes: *RectangularPrism* > *Cube* adheres to the *Liskov Substitution Principle*.
- Implemented Design Patterns:
    - *Strategy Pattern*: Applied in the selection of the cube intersection algorithm based on their orthogonality. It is only implemented for orthogonal cubes; the algorithm for rotated cubes is not implemented.

## Tests

The tests are defined following the *AAA pattern* (Arrange, Act, Assert) and use *fluent assertions* for assertions.

### Test Coverage

The implemented tests have a test coverage of 100%. 

## CI / CD

![Build and test workflow](https://github.com/joaquinalfonso/cube-intersection-kata-dotnet/actions/workflows/dotnet.yml/badge.svg)

To ensure the robustness of the solution, a [Github Action](.github/workflows/dotnet.yml) is included to [build and run the tests](https://github.com/joaquinalfonso/cube-intersection-kata-dotnet/actions) every time there is a push or a Pull Request to the main branch.

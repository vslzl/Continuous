using Continuous.Web.Models;
using FluentAssertions;

namespace Continuous.Web.Tests;

public class UnitTest1
{
    [Fact]
    public void Car_AfterInit_ShouldBeStopped()
    {
        var car = new Car();
        car.Speed.Should().Be(0);
    }
    
    [Fact]
    public void Car_WhenAccelerated_Speed_ShouldBeGreaterThanZero()
    {
        var car = new Car();
        car.Accelerate(10);
        car.Speed.Should().BeGreaterThan(0);
    }
}
using NUnit.Framework;
using NUnitDemo;
using System;

[TestFixture]
public class TriangleTests
{
    private object Assert;

    [Test]
    public void TestValidTriangle()
    {
        Assert.AreEqual("The triangle is valid.", Triangle.ValidTriangle(60, 60, 60));
        Assert.AreEqual("The triangle is valid.", Triangle.ValidTriangle(90, 45, 45));
    }

    [Test]
    public void TestInvalidTriangle()
    {
        Assert.AreEqual("The triangle is NOT valid.", Triangle.ValidTriangle(30, 60, 90));
        object value = Assert.AreEqual("The triangle is NOT valid.", Triangle.ValidTriangle(0, 0, 0));
    }
}

internal class Triangle
{
    internal static object ValidTriangle(int v1, int v2, int v3)
    {
        throw new NotImplementedException();
    }
}

internal class TestAttribute : Attribute
{
}
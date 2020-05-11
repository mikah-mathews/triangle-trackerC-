using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle.Models;

namespace Triangle.Tests 
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod] // this works
    public void CalculateTriangle_IsNotTriangle_True()
    {
      TriangleTracker triangleTracker = new TriangleTracker();
      Assert.AreEqual("Cannot make a valid triangle.", triangleTracker.CalculateTriangle(3, 9, 22));
    }
    
  [TestMethod]
    public void CalculateTriangle_IsEquilateralTriangle_True()
    {
      TriangleTracker triangleTracker = new TriangleTracker();
      Assert.AreEqual("You made an equilateral triangle.", triangleTracker.CalculateTriangle(2, 2, 2));
    }

    [TestMethod]
    public void CalculateTriangle_IsIsoscelesTriangle_True()
    {
      TriangleTracker triangleTracker = new TriangleTracker();
      Assert.AreEqual("You made an isosceles triangle.", triangleTracker.CalculateTriangle(2, 4, 2));
    }

    [TestMethod]
    public void CalculateTriangle_IsScaleneTriangle_True()
    {
      TriangleTracker triangleTracker = new TriangleTracker();
      Assert.AreEqual("You made a scalene triangle.", triangleTracker.CalculateTriangle(4,5,7));
    }
  }
}
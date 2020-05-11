using System;
using System.Collections.Generic;

namespace Triangle.Models {
  public class TriangleTracker
  {
    public List<int> sides;

    public TriangleTracker()
    {
      sides = new List<int>();
    }

    public string CalculateTriangle(int side1, int side2, int side3)
    {
      sides.Add(side1);
      sides.Add(side2);
      sides.Add(side3);
      sides.Sort();
      if(sides[2] > (sides[0] + sides[1]))
      {
        return "Cannot make a valid triangle.";
      }
      else if(sides[0] == sides[1] && sides[1] == sides[2])
      {
        return "You made an equilateral triangle.";
      }
      else if(sides[0] == sides[1] || sides[1] == sides[2] || sides[2] == sides[0])
      {
        return "You made an isosceles triangle.";
      }
      else {
        return "You made a scalene triangle.";
      }
    }
  }
}



/*
  not valid: longest side > other 2 combined
  equilateral: all side equal
  isosceles: 2 sides equal
  scalene: no sides equal
*/
using System;
using Triangle.Models;

namespace Triangle {
  public class Program {

public static void Main(){
  TriangleTracker triangle = new TriangleTracker();
  Console.WriteLine("Enter the length for side 1: ");
  int side1 = int.Parse(Console.ReadLine());

  Console.WriteLine("Enter the length for side 2: ");
  int side2 = int.Parse(Console.ReadLine());

  Console.WriteLine("Enter the length for side 3: ");
  int side3 = int.Parse(Console.ReadLine());

  string triangleType = triangle.CalculateTriangle(side1, side2, side3);
  Console.WriteLine(triangleType); 
}

}
}
using System;

namespace Shape
{
  class Program
  {
    static void Main(string[] args)
    {
      // Shape Test
      Shape shape = new Shape();
      Console.WriteLine(shape);

      shape = new Shape("red", false);
      Console.WriteLine(shape);

      // Circle Test
      Circle circle = new Circle();
      Console.WriteLine(circle);

      circle = new Circle(3.5);
      Console.WriteLine(circle);

      circle = new Circle(3.5, "indigo", false);
      Console.WriteLine(circle);

      // Square Test
      Square square = new Square();
      Console.WriteLine(square);

      square = new Square(2.3);
      Console.WriteLine(square);

      square = new Square(5.8, "yellow", true);
      Console.WriteLine(square);

      Shape[] cachinh = { new Circle(), new Rectangle(), new Square() };
      
      foreach (Shape hinh in cachinh)
      {
        Random rand = new Random();
        double re = rand.Next(1, 100);
        if (hinh is Circle tron)
        {
          Console.WriteLine(tron.getArea());
          tron.Resize(re);
          Console.WriteLine(tron.getArea());
        }
        if (hinh is Rectangle chunhat)
        {
          Console.WriteLine(chunhat.getArea());
          chunhat.Resize(re);
          Console.WriteLine(chunhat.getArea());
        }
        if (hinh is Square vuong)
        {
          Console.WriteLine(vuong.getArea());
          vuong.Resize(re);
          Console.WriteLine(vuong.getArea());
        }
      }
    }
  }
}

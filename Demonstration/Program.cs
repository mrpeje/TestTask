using TestTaskV2;

Triangle TT = new TestTaskV2.Triangle(3, 4, 5);
Shape CC = new TestTaskV2.Circle(3);

if (TT.IsRightTriangle())
    Console.WriteLine("Triangle is right");

Console.WriteLine("Area of triangle " + TT.GetArea());
Console.WriteLine("Area of Circle " + CC.GetArea());
        



using TestTaskV2;


ITriangle TT = new Triangle(3, 4, 5);
ICircle CC = new Circle(3);
CC.Radius = 5;
IShape shape = TT;
if (TT.IsRightTriangle())
    Console.WriteLine("Triangle is right");

Console.WriteLine("Area of triangle " + TT.GetArea());
Console.WriteLine("Area of Circle " + CC.GetArea());
        



using Shapes;

Shape[] shapes = new Shape[20];
float totalArea = 0;


for (int i = 0; i < shapes.Length; i++)
{
    shapes[i] = Shape.GenerateShape();
}

for (int i = 0; i < shapes.Length; i++)
{
    Console.WriteLine($"{i}: {shapes[i]}");
    totalArea += shapes[i].Area;
}
totalArea /= shapes.Length;
Console.WriteLine($"\nMedelvärdet på arean är: {totalArea:f2} enheter");
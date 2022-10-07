using Shapes;

Shape[] shapes = new Shape[21];
float totalArea = 0;


for (int i = 0; i < 21; i++)
{
    shapes[i] = Shape.GenerateShape();
}

for (int i = 0; i < shapes.Length - 1; i++)
{
    Console.WriteLine($"{i + 1}: {shapes[i]}");
    totalArea += shapes[i].Area;
}
totalArea /= shapes.Length - 1;
Console.WriteLine($"\nMedelvärdet på arean är: {totalArea:f2} enheter");
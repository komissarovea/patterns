void GetRectangleData(in int width, in int height, out int rectArea, out int rectPerimetr)
{
    //width = 25; // нельзя изменить, так как width - входной параметр
    rectArea = width * height;
    rectPerimetr = (width + height) * 2;
}

int w = 10;
int h = 20;
GetRectangleData(w, h, out var area, out var perimetr);

Console.WriteLine($"Площадь прямоугольника: {area}");       // 200
Console.WriteLine($"Периметр прямоугольника: {perimetr}");   // 60
Console.Clear();
double k1 = InputeNum();
double b1 = InputeNum();
double k2 = InputeNum();
double b2 = InputeNum();



Console.WriteLine($"The lines intersect at the points: ({FindingIntersectionLinesAtPointX(k1,b1,k2,b2)};{FindingIntersectionLinesAtPointY(k1,FindingIntersectionLinesAtPointX(k1,b1,k2,b2), b1)})");

double InputeNum()
{
    Console.WriteLine("Enter the numbers one by one in the order k1, b1, k2, b2 ");
    bool uinput = double.TryParse(Console.ReadLine(), out double num);
    if (uinput)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Incorrect values");
        return -1;
    }
}

double FindingIntersectionLinesAtPointX(double k1, double b1, double k2, double b2)
{
    double x = -(b1 - b2) / (k1 - k2);
    x = Math.Round(x, 3);
    return x;
}

double FindingIntersectionLinesAtPointY(double k1 , double x, double b1)
{
    double y = k1 * x + b1;
    y = Math.Round(y, 3);
    return y;
}
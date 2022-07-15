double Orthocenter(double k1, double k2, double b1, double b2)
{
    double x = (b2 - b1)/(k1 - k2);
    return x;
}
Console.WriteLine("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
if(k1==k2) 
Console.WriteLine("Please note k1 and k2 cannot be equal");
else
Console.WriteLine("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
double x = Orthocenter(k1, k2, b1, b2);
double y = k1*x+b1;
Console.WriteLine("Crosspoint is " + (x + "," + y)); 

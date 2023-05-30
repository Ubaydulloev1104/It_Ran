while (true)
{

    double a;
    double b;
    double c;
 
    
    Console.Write("Вводите a=");
    bool isnumber_a = double.TryParse(Console.ReadLine(), out a);
    if (isnumber_a)
    {
        Console.Write("Вводите b=");
        bool isnumber_b = double.TryParse(Console.ReadLine(), out b);
        if (isnumber_b)
        {
            Console.Write("Вводите c=");
            bool isnumber_c = double.TryParse(Console.ReadLine(), out c);

            if (isnumber_c)
            {
               double d = (b * b) - 4 * a * c;
                if (d > 0)
                {
                    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                   Console.WriteLine($"Уравнение имеет два кроня : X1={x1} , X2={x2} ");
                } 
                else if (d == 0)
                {
                    double x=-b/ (2 * a);
                    Console.WriteLine($"Уравнение имеет один кронь : X={x}");
                }
                else
                {
                    Console.WriteLine("Уравнение не имеет действительные кроней");
                }
                break;
            }
            else
            {
                Console.WriteLine(" а должин бить числом ");
            }
        }
        else
        {
            Console.WriteLine(" а должин бить числом ");
        }
    }
    else
    {
        Console.WriteLine(" а должин бить числом ");
    }
}
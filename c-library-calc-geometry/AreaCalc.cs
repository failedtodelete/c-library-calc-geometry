using System;

namespace c_library_calc_geometry
{
    public class AreaCalc
    {
        public static void Main()
        {
            {
                Console.WriteLine("Welcome to Area Calculater.\n" +
                "Area of which of the following shapes would you like to calculate:\n" +
                "Circle - choose 1\n" +
                "Triangle - choose 2\n" +
                "Shape with more than 3 sides - choose 3");

                int casenumber = Convert.ToInt32(Console.ReadLine());
                switch (casenumber)
                {
                    case 1:
                        Console.WriteLine("\nPlease, give a circle radius in cm:\n");
                        double r = Convert.ToDouble(Console.ReadLine());
                        AreaCalc y = new AreaCalc();
                        Console.WriteLine("\nThe area of the circle is " + y.CircleA(r) + " cm2.\n");
                        break;
                    case 2:
                        Console.WriteLine("\nPlease, give a length of 1st side of a triangle in cm:\n");
                        double d = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\nPlease, give a length of 2nd side of a triangle in cm:\n");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\nPlease, give a length of 3rd side of a triangle in cm:\n");
                        double c = Convert.ToDouble(Console.ReadLine());
                        double longestside;
                        AreaCalc x = new AreaCalc();

                        if ((d <= 0) || (b <= 0) || (c <= 0))
                        {
                            Console.WriteLine("\nThis is not a triangle.\n");
                        }
                        else
                        {
                            if ((d + b <= c) || (d + b <= c) || (d + b <= c))
                            {
                                Console.WriteLine("\nThis is not a triangle.\n");
                            }
                            else
                            {
                                longestside = c;
                                if (longestside < d)
                                {
                                    c = longestside;
                                    longestside = d;
                                    d = c;
                                }
                                if (longestside < b)
                                {
                                    c = longestside;
                                    longestside = b;
                                    b = c;
                                }
                                if (d * d + b * b == longestside * longestside)
                                {
                                    Console.WriteLine("\nThis is a rightangled triangle.\n");
                                }
                            }
                        }
                            Console.WriteLine("\nThe area of the triangle is " + x.TriangleA(d,b,c) + " cm2.");
                        
                        break;
                    case 3:
                        Console.WriteLine("\nApologies, the feature is under development.\n Check https://github.com/olegarky/c-library-calc-geometry for updates. Thank you :)");
                        break;
                }
            
                Console.ReadKey();
            }
        }

        public double CircleA(double r)
        {
            double a = r * r * Math.PI;
            return a;
        }
        public double TriangleA(double d, double b, double c)
        {
            double p = (d + b + c) / 2;
            double a = Math.Sqrt(p * (p - d)*(p - b)*(p - c));
            return a;
        }
       
    }
}

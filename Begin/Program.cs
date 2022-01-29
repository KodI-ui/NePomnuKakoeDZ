using System;

namespace Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            Begin40();
        }
        static void Begin40()
        {
            double A1, B1, C1, A2, B2, C2;
            Console.Write("A1: ");
            A1 = double.Parse(Console.ReadLine());
            Console.Write("B1: ");
            B1 = double.Parse(Console.ReadLine());
            Console.Write("C1: ");
            C1 = double.Parse(Console.ReadLine());
            Console.Write("A2: ");
            A2 = double.Parse(Console.ReadLine());
            Console.Write("B2: ");
            B2 = double.Parse(Console.ReadLine());
            Console.Write("C2: ");
            C2 = double.Parse(Console.ReadLine());

            double D = A1 * B2 - A2 * B1;

            double x, y;
            x = (C1 * B2 - C2 * B1) / D;
            y = (A1 * C2 - A2 * C1) / D;

            Console.Write($"x = {x}; y = {y}.");


        }
        static void Begin1()
        {
            int a = int.Parse(Console.ReadLine());
            int P = 4 * a;
            Console.WriteLine(P);
        }
        static void Begin2()
        {
            int a = int.Parse(Console.ReadLine());
            int S = a * a;
            Console.WriteLine(S);
        }
        static void Begin3()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int S = a * b;
            int P = 2 * (a + b);
            Console.WriteLine($"S = {S}; P = {P}");
        }
        static void Begin4()
        {
            const double Pi = 3.14;
            double d = double.Parse(Console.ReadLine());
            double L = d * Pi;
            Console.WriteLine(L);
        }
        static void Begin5()
        {
            int a = int.Parse(Console.ReadLine());
            int V = a * a * a;
            int S = 6 * (a * a);
            Console.WriteLine($"V = {V}; S = {S}");
        }
        static void Begin6() {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int V = a * b * c;
            int S = 2 * (a * b + b * c + a * c);
            Console.WriteLine($"V = {V}; S = {S}.");
        }
        static void Begin7()
        {
            const double Pi = 3.14;
            double R = double.Parse(Console.ReadLine());
            double L = 2 * Pi * R;
            double S = Pi * (R * R);
            Console.WriteLine($"L = {L}; S = {S}");
        }
        static void Begin8()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int midNum = (a + b) / 2;
            Console.WriteLine(midNum);
        }
        static void Begin9()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double midNum = Math.Sqrt(a * b);
            Console.WriteLine(midNum);
        }
        static void Begin10()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double aNaA = a * a;
            double bNaB = b * b;
            double sum = aNaA + bNaB;
            double minus = aNaA - bNaB;
            double ymnozhit = aNaA * bNaB;
            double delenie = aNaA / bNaB;
            Console.WriteLine($"{sum} {minus} {ymnozhit} {delenie}");
        }
        static void Begin11()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double aNaA = Math.Abs(a);
            double bNaB = Math.Abs(b);
            double sum = aNaA + bNaB;
            double minus = aNaA - bNaB;
            double ymnozhit = aNaA * bNaB;
            double delenie = aNaA / bNaB;
            Console.WriteLine($"{sum} {minus} {ymnozhit} {delenie}");
        }
        static void Begin12()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            double P = a + b + c;
            Console.WriteLine($"{c} {P}");
        }
        static void Begin13()
        {
            double R1 = double.Parse(Console.ReadLine());
            double R2 = double.Parse(Console.ReadLine());
            const double Pi = 3.14;
            double S1 = Pi * (R1 * R1);
            double S2 = Pi * (R2 * R2);
            double S3 = S1 - S2;
            Console.WriteLine($"{S1} {S2} {S3}");
        }
        static void Begin14()
        {
            const double Pi = 3.14;
            double L = double.Parse(Console.ReadLine());
            double R = L / 2 * Pi;
            double S = Pi * (R * R);
            Console.WriteLine($"{R} {S}");
        }
        static void Begin15()
        {
            const double Pi = 3.14;
            double S = double.Parse(Console.ReadLine());
            double RR = S / Pi;
            double R = Math.Sqrt(RR);
            double L = 2 * Pi * R;
            Console.WriteLine($"{R} {L}");

        }
        static void Begin16()
        {
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double x3 = Math.Abs(x2 - x1);
            Console.WriteLine(x3);

        }
        static void Begin17()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());
            double BC = Math.Abs(C - B);
            double AC = Math.Abs(C - A);
            double BCPlusAC = BC + AC;
            Console.WriteLine($"{BC} {AC} {BCPlusAC}");
        }
        static void Begin18()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());
            double AC = Math.Abs(C - A);
            double BC = Math.Abs(C - B);
            double ACYmnozhitBC = AC * BC;
            Console.WriteLine($"{AC} {BC} {ACYmnozhitBC}");
        }
        static void Begin24()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            double temp = A;
            A = B;
            B = C;
            C = temp;
            Console.WriteLine($"{A} {B} {C}");

        }
    }
}

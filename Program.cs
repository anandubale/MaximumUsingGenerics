using System;

namespace MaxUsingGenerics
{
    class Program

    {
        public static int MaximumIntegerNumber(int Firstvalue, int secondvalue, int thirdvalue)
        {
            if (Firstvalue.CompareTo(secondvalue) > 0 && Firstvalue.CompareTo(thirdvalue) > 0 ||
                Firstvalue.CompareTo(secondvalue) >= 0 && Firstvalue.CompareTo(thirdvalue) > 0 ||
                Firstvalue.CompareTo(secondvalue) > 0 && Firstvalue.CompareTo(thirdvalue) >= 0)
            {
                return Firstvalue;
            }
            if (secondvalue.CompareTo(Firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0 ||
                secondvalue.CompareTo(Firstvalue) >= 0 && secondvalue.CompareTo(thirdvalue) > 0 ||
                secondvalue.CompareTo(Firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) >=0)
            {
                return secondvalue;
            }
            if (thirdvalue.CompareTo(Firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0 ||
               thirdvalue.CompareTo(Firstvalue) >= 0 && thirdvalue.CompareTo(secondvalue) > 0 ||
               thirdvalue.CompareTo(Firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) >= 0)
            {
                return thirdvalue;
            }
            return Firstvalue;
        }

        public static double MaximumFloatNumber(double Firstvalue, double secondvalue, double thirdvalue)
        {
            if (Firstvalue.CompareTo(secondvalue) > 0 && Firstvalue.CompareTo(thirdvalue) > 0 ||
                Firstvalue.CompareTo(secondvalue) >= 0 && Firstvalue.CompareTo(thirdvalue) > 0 ||
                Firstvalue.CompareTo(secondvalue) > 0 && Firstvalue.CompareTo(thirdvalue) >= 0)
            {
                return Firstvalue;
            }
            if (secondvalue.CompareTo(Firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0 ||
                secondvalue.CompareTo(Firstvalue) >= 0 && secondvalue.CompareTo(thirdvalue) > 0 ||
                secondvalue.CompareTo(Firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) >=0)
            {
                return secondvalue;
            }
            if (thirdvalue.CompareTo(Firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0 ||
               thirdvalue.CompareTo(Firstvalue) >= 0 && thirdvalue.CompareTo(secondvalue) > 0 ||
               thirdvalue.CompareTo(Firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) >= 0)
            {
                return thirdvalue;
            }
            return Firstvalue;
        }
            static void Main(string[] args)
            {
                Console.WriteLine(MaximumIntegerNumber(25, 30, 5));
                Console.WriteLine(MaximumFloatNumber(25.5, 30.2, 5.3));
            }

    }
}

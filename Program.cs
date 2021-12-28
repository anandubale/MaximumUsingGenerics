using System;
namespace MaxUsingGenerics
{
    class Program
    {

        /*
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

        public static String MaximumstringValue(String FirstString, String Secondstring, String ThirdString)
        {
            if (FirstString.CompareTo(Secondstring) > 0 && FirstString.CompareTo(ThirdString) > 0 ||
                FirstString.CompareTo(Secondstring) >= 0 && FirstString.CompareTo(ThirdString) > 0 ||
                FirstString.CompareTo(Secondstring) > 0 && FirstString.CompareTo(ThirdString) >= 0)
            {
                return FirstString;
            }
            if (Secondstring.CompareTo(FirstString) > 0 && Secondstring.CompareTo(ThirdString) > 0 ||
                Secondstring.CompareTo(FirstString) >= 0 && Secondstring.CompareTo(ThirdString) > 0 ||
                Secondstring.CompareTo(FirstString) > 0 && Secondstring.CompareTo(ThirdString) >= 0)
            {
                return Secondstring;
            }
            if (ThirdString.CompareTo(FirstString) > 0 && ThirdString.CompareTo(Secondstring) > 0 ||
               ThirdString.CompareTo(FirstString) >= 0 && ThirdString.CompareTo(Secondstring) > 0 ||
               ThirdString.CompareTo(FirstString) > 0 && ThirdString.CompareTo(Secondstring) >= 0)
            {
                return ThirdString;
            }
            return FirstString;
        }
        */
        static void Main(string[] args)
        {

            Console.WriteLine(" Maximum Number is:-");
            int[] intArray = { 112, 344, 432, 555, 678 };
            GenericMax<int> generic = new GenericMax<int>(intArray);
            generic.printmaxValue();

            float[] floatArray = { 112f, 344f, 432f, 555f, 678f };
            GenericMax<float> genericdouble = new GenericMax<float>(floatArray);
            generic.printmaxValue();

            string[] stringArray = { "112", "344", "432", "555", "678" };
            GenericMax<string> genericstring = new GenericMax<string>(stringArray);
            generic.printmaxValue();


        }
        
    }
}

namespace Specials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(short.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(ushort.MaxValue);
            Console.WriteLine(ushort.MinValue);
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(uint.MinValue);
            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine(ulong.MinValue);
            Console.WriteLine(float.PositiveInfinity);
            Console.WriteLine(float.NegativeInfinity);
            Console.WriteLine(float.NaN);
            Console.WriteLine(double.PositiveInfinity);
            Console.WriteLine(double.NegativeInfinity);
            Console.WriteLine(double.NaN);
            int i1 = short.MaxValue;
            int i2 = short.MinValue;
            int i3 = sbyte.MaxValue;
            int i4 = sbyte.MinValue;
            Console.WriteLine((short) (n1 + 1));
            Console.WriteLine((short) (n2 - 1));
            Console.WriteLine((sbyte) (n3 + 1));
            Console.WriteLine((sbyte) (n4 - 1));
            double n5 = 2 * double.MaxValue;
            float n6 = -2 * float.MaxValue;
            Console.WriteLine(i5);
            Console.WriteLine(i6);

            float n7, n8;
            double n9, n10;
            n7 = n8 = 89239.0f;
            n9 = n10 = 294829.0f;

            Console.WriteLine(n7 == n8 + 0.001f);
            
            Console.WriteLine(n9 == n10 + 0.000000000001f);
        }
    }
}
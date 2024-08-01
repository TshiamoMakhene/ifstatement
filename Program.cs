namespace ifstatement
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            int a, b, c;
            Console.WriteLine("Enter three numbers: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());    
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("{0} is the largest number ", a);
            }
            else if (b > c)
            {
                Console.WriteLine("{0} is the largest number ", b);
            }
            */
            int n;
            Console.WriteLine("ENter a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine($"{n} is divisible by 2");
            }
            else {
                Console.WriteLine(  $"{n} is not divisible by 2 ");
            }
            Console.ReadKey();
        }
    }
}

namespace _240805_05_Addition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] s;

            Console.Clear();
            s = Console.ReadLine().Split(' ');

            int a = Int32.Parse(s[0]);
            int b = Int32.Parse(s[1]);
            int answer = a + b;

            Console.WriteLine($"{a} + {b} = " + answer);
        }
    }
}

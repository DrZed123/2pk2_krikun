namespace PZ_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N:");
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 1;
            int result = 0;
            while (true)
            {
                if (result < n - k * k)
                {
                    result = k * k;
                    k++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(k + 1);
        }
    }
}
using Numbers;

namespace MyNameSpace
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Checker.GetPrimesTill(number: 1000);
            foreach (int num in list)
                Console.Write(num + ", ");
        }
    }
}
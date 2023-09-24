namespace Numbers
{
    class Checker
    {
        public static List<int> GetPrimesTill(int number)
        {
            List<int> list = new List<int>();
            for (int num = 2; num < number; num++)
            {
                if (IsPrime(num))
                {
                    list.Add(num);
                }
            }
            return list;
        }
        public static bool IsPrime(int number)
        {
            if (number == 2 || number == 3) return true;
            for (int num = 2; num < number / 2; num++)
            {
                if (number % num == 0) return false;
            }
            return true;
        }
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        public static int NextNumber(int number)
        {
            return number + 1;
        }
    }
}
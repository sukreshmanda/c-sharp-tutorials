namespace Prime
{
    class PrimeNumber
    {
        public static bool IsPrime(int number)
        {
            if (number == 2 || number == 3) return true;
            for (int num = 2; num < number / 2; num++)
            {
                if (number % num == 0) return false;
            }
            return true;
        }
    }
}
namespace UnitTesting
{
    public static class MathTool
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static bool IsOdd(int a)
        {
            return (a & 1) != 0;
        }

        /// <summary>
        /// Checks the integer if it's larger than a million
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool IsLargeThanAMillion(int a)
        {
            if (a > 1000000)
                return true;
            else
                return false;
        }
    }
}
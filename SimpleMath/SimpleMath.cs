namespace SimpleMath
{
    public static class SimpleMath
    {
        /// <summary>
        ///     Add 2 integers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Add(int a, int b)
        {
            int res = a + b;

            return res;
        }

        /// <summary>
        ///     Subtract 2 integers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Subtract(int a, int b)
        {
            int res = a - b;

            return res;
        }

        /// <summary>
        ///     Multiply 2 integers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Multiply(int a, int b)
        {
            int res = a * b;

            return res;
        }

        /// <summary>
        ///     Divide 2 integers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Divide(int a, int b)
        {
            int res = a / b;

            return res;
        }

        /// <summary>
        ///     Sum the numbers from 1 to n
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int ConsecutiveSum(int n)
        {
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += i;
            }

            return sum;
        }
    }
}

namespace LeetCodeEasy217
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result1 = Solution.ContainsDuplicate([1, 2, 3, 1]);
            if (!result1)
            {
                Console.WriteLine($"result1 is: {result1} instead of true");
                return;
            }
            bool result2 = Solution.ContainsDuplicate([1, 2, 3, 4]);
            if (result2)
            {
                Console.WriteLine($"result2 is: {result2} instead of false");
                return;
            }

            bool result3 = Solution.ContainsDuplicate([1, 1, 1, 3, 3, 4, 3, 2, 4, 2]);
            if (!result3)
            {
                Console.WriteLine($"result3 is: {result3} instead of false");
                return;
            }

            bool result4 = Solution.ContainsDuplicate([0]);
            if (result4)
            {
                Console.WriteLine($"result4 is: {result4} instead of false");
                return;
            }

            Console.WriteLine($"it works perfectly!");
        }
    }
}

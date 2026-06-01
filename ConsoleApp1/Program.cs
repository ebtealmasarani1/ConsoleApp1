namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            int[] list = { 4, 6, 9, 41, 435, 476, 501, 511, 820 };

            int searchValue = 9;

            BinarySearch(list, searchValue);
        }

        private static void BinarySearch(int[] list, int searchValue)
        {
            int start = 0;
            int end = list.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (list[mid] == searchValue)
                {
                    Console.WriteLine($"Värdet {list[mid]} hittat!");
                    return;
                }
                else if (searchValue < list[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

        }
    }
}

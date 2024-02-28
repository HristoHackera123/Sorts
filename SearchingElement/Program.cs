namespace SearchingElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a SORTED list then a number to be inserted on the next line");
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int searched = int.Parse(Console.ReadLine());
            bool contains = false;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums.Contains(searched))
                {
                    contains = true;
                    break;
                }
            }
            if (contains)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

namespace InsertElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a SORTED list then a number to be inserted on the next line");
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int inserted = int.Parse(Console.ReadLine());
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > inserted)
                {
                    nums.Insert(i, inserted);
                    break;
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        } 
    }
}

namespace Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool small = true;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] >= nums[j])
                    {
                        int swap = nums[j];
                        nums[j] = nums[i];
                        nums[i] = swap;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}

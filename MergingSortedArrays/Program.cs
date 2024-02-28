namespace MergingSortedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> merged = new List<int>();
            int current = 0;
            int start = 0;
            int length = 0;
            int best = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = current; j < array2.Length; j++)
                {
                    if (array1[j] < array2[i])
                    {
                        start = j;
                        length++;
                        best = length;
                        continue;
                    }
                    else
                    {
                        if (array1[i] < array2[i])
                    }
                }
            }
            Console.WriteLine(string.Join(" ", merged)); // tazi zadacha e pulna tupotiq
        }
    }
}

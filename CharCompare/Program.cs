namespace CharCompare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] array1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] array2 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            int shorterArr = 0;
            bool diff;
            if (array1.Length != array2.Length)
            {
                diff = true;
                if (array1.Length < array2.Length)
                {
                    shorterArr = array1.Length;
                }
                else
                {
                    shorterArr = array2.Length;
                }
            }
            else
            {
                shorterArr = array1.Length;
                diff = false;
            }
            int betterArr = 0; //това е по-важното
            for (int i = 0; i < shorterArr; i++)
            {
                if (array1[i] != array2[i])
                {
                    if (array1[i] < array2[i])  
                    {
                        betterArr = 1;
                    }
                    else
                    {
                        betterArr = 2;
                    }
                }
            }
            if ((!diff && betterArr == 0)|| betterArr == 1)
            {
                Console.WriteLine(string.Join("", array1));
                Console.WriteLine(string.Join("", array2));
            }
            else if (betterArr == 2)
            {
                Console.WriteLine(string.Join("", array2));
                Console.WriteLine(string.Join("", array1));
            }
            else
            {
                if ((!diff && betterArr == 0)|| shorterArr == array1.Length)
                {
                    Console.WriteLine(string.Join("", array1));
                    Console.WriteLine(string.Join("", array2));
                }
                else
                {
                    Console.WriteLine(string.Join("", array2));
                    Console.WriteLine(string.Join("", array1));
                }
            }
        }
    }
}

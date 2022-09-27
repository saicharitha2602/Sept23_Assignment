namespace Sept23_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3 };

            for (int i = 0; i < arr.Length + 1; i++)
            {
                try
                {
                    Console.WriteLine(arr[i]);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
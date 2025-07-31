namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to My Terminal App!");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine() ?? string.Empty;
            string[] nameParts = name.Split(' ');
            int[] nameLengths = new int[nameParts.Length];
            for (int i = 0; i < nameParts.Length; i++)
            {
                nameLengths[i] = nameParts[i].Length;
                Console.WriteLine($"Part {i}: {nameParts[i]}");
            }
            Console.WriteLine($"Hello, {nameParts[0]}!");
        }
    }
}
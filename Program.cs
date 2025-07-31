namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Welcome to My Terminal App!");
            // Console.Write("Enter your name: ");
            // string name = Console.ReadLine() ?? string.Empty;
            // string[] nameParts = name.Split(' ');
            // int[] nameLengths = new int[nameParts.Length];
            // for (int i = 0; i < nameParts.Length; i++)
            // {
            //     nameLengths[i] = nameParts[i].Length;
            //     Console.WriteLine($"Part {i}: {nameParts[i]}");
            // }
            // Console.WriteLine($"Hello, {nameParts[0]}!");

            // Create a new Car object
            Car myCar = new Car
            {
                Make = "Toyota",
                Model = "Camry",
                Year = 2020
            };




            // Display car information
            myCar.DisplayInfo();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void DisplayInfo()
        {
            string uModel = this.Make.ToUpper();
            Console.WriteLine($"Car: {Year} {uModel} {Model}");
        }
    }
}
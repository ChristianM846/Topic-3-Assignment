namespace Topic_3_Assignment
    //Christian Moyes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Greeting
            string name;
            int age, year, num1, num2, num3;
            double dis1, dis2, dis3;
            DateTime yearGetter = DateTime.Now;
            year = yearGetter.Year;
            Console.WriteLine("Hello, what is your name?");
            name = Console.ReadLine();
            Console.WriteLine($"Hello {name}, it's nice to meet you. How old are you?");
            age = Convert.ToInt32(Console.ReadLine());

            if (age <= 0)
            {
                Console.WriteLine($"You are a lair. I don't like liars. Goodbye {name}");
            }
            else
            {
                Console.WriteLine($"So your name is {name}, and you are {age} years old? That means you were born around {year - age}, (unless you haven't had your birthday yet this year)");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            // 2. Adder
            Console.WriteLine("Hello, let's do some math! Can you give a whole number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"So the first number is {num1}? Can you give me another:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The second number is {num2}. One more?");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"So the three numbers you chose are {num1}, {num2}, and {num3}? Those have a sum of {num1 + num2 + num3}");
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();


            // 3. Distance
            Console.WriteLine("Hello, I'm here to find the avarge between the three distances (In Km) you will tell me. Please input the first distance:");
            dis1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Your first distance is {dis1}Km. Please input the second distance:");
            dis2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Your second distance is {dis2}Km. Please input the third distance:");
            dis3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Your thrid and final distance is {dis3}Km. Please give me moment to calculate the avaerage between them. Press Enter to continue.");
            Console.WriteLine($"The average between the three distances is {Math.Round(((dis1 + dis2 + dis3)/3),2)}");

        }
    }
}
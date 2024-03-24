namespace STUDY.CONSOLE.MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MathGame!");
            Console.WriteLine("Available operators: +, -, *, /");
            Console.WriteLine("Please note that divisions only result in full numbers!");
            Console.WriteLine("");


            Console.Write("Please enter the first number: ");
            string userInput1 = Console.ReadLine();
            int num1 = 0;
            try
            {
                num1 = Int32.Parse(userInput1);
            }
            catch
            {
                Console.WriteLine("'{0}' cant be parsed from string to int!", userInput1);
            }

            Console.Write("Please enter the operator (+, -, *, /): ");
            string userInput2 = Console.ReadLine();
            if(userInput2 != "+" && userInput2 != "-" && userInput2 != "*"  && userInput2 != "/")
            {
                Console.WriteLine("You have not entered a correct operator.");
            }

            Console.Write("Please enter the second number: ");
            string userInput3 = Console.ReadLine();
            int num2 = 0;
            try
            {
                num2 = Int32.Parse(userInput3);
            }
            catch
            {
                Console.WriteLine("'{0}' cant be parsed from string to int!", userInput3);
            }

            int result = 0;
            if(userInput2 == "+")
            {
                result = num1 + num2;
            }
            else if (userInput2 == "-")
            {
                result = num1 - num2;
            }
            else if (userInput2 == "*")
            {
                result = num1 * num2;
            }
            else if (userInput2 == "/")
            {
                result = num1 / num2;
            }

            Console.WriteLine("The result is: {0}", result);
        }
    }
}
namespace STUDY.CONSOLE.MathGame
{
    internal class Program
    {

        static void Calculation(int userInput1, string userInput2, int userInput3)
        {
            int result = 0;
            if (userInput2 == "+")
            {
                result = userInput1 + userInput3;
            }
            else if (userInput2 == "-")
            {
                result = userInput1 - userInput3;
            }
            else if (userInput2 == "*")
            {
                result = userInput1 * userInput3;
            }
            else if (userInput2 == "/")
            {
                // Division by 0 possible.. Try to fix!
                if ((userInput1 % userInput3 == 0) && (userInput3 >= 1) && (userInput3 <= 100))
                {
                    try
                    {
                        result = userInput1 / userInput3;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Can't divide by 0!");
                    }
                        
                }
                else
                {
                    Console.WriteLine("Either the Modulo is not 0, or the dividend is either below '0' or above '100'.", userInput1, userInput3);
                    Console.WriteLine("Result will be shown as '0'.");
                    result = 0;
                }
            }
            Console.WriteLine("The result is: {0}", result);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("MathGame!");
            Console.WriteLine("Available operators: +, -, *, /");
            Console.WriteLine("Please note that divisions will only work if the result is a full number!");
            Console.WriteLine("Also dividends should only be between 0 & 100!");
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

            Calculation(num1, userInput2, num2);
        }
    }
}
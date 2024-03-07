namespace EmployeeRegister.Helpers
{
    public static class Util
    {
        public static string StringInput(string input)
        {
            bool success = false;
            string userInput;
            do
            {
                Console.WriteLine($"{input}:");
                userInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine($"\"{userInput}\" is not a valid input.");
                }
                else
                {
                    success = true;
                }

            } while (success);

            return userInput;
        }

        public static uint IntInput(string input)
        {
            do
            {
                string userInput = StringInput(input);
                if (uint.TryParse(userInput, out uint result))
                {
                    return result;
                }

            } while (true);
        }
    }
}
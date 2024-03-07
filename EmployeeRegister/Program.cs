using EmployeeRegister.Helpers;

namespace EmployeeRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool addEmployee = true;
            Console.WriteLine("Employee Register");

            Employee addNewEmployee = new Employee();

            while (addEmployee)
            {
                Console.WriteLine("\n\nWould you like to add a new employee to the registry? (Y/N)");
                string userInput = Console.ReadLine();

                Console.Clear();

                switch (userInput)
                {
                    case "y":
                    case "Y":
                        Console.Write("\nPlease enter employee name: ");
                        string name = Console.ReadLine();

                        Console.Write("Please enter employee salary: ");
                        uint salary = uint.Parse(Console.ReadLine());

                        addNewEmployee.NewEmployee(name, salary);

                        Console.WriteLine("\nCurrently in the registry: ");
                        addNewEmployee.PrintEmployeeList();
                        break;

                    case "n":
                    case "N":
                        Console.WriteLine("Please enter any key to exit the application");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine($"\"{userInput}\" is a valid input");
                        break;

                }
            }
        }
    }
}
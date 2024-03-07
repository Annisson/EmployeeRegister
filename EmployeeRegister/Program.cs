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

                if (userInput == "Y" || userInput == "y")
                {
                    Console.Write("\nPlease enter employee name: ");
                    string name = Console.ReadLine();

                    Console.Write("Please enter employee salary: ");
                    uint salary = uint.Parse(Console.ReadLine());

                    addNewEmployee.NewEmployee(name, salary);

                    Console.WriteLine("\nCurrently in the registry: ");
                    addNewEmployee.PrintEmployeeList();

                    continue;

                }
                else if (userInput == "N" || userInput == "n")
                {
                    Console.WriteLine("Please enter any key to exit the application");
                    addEmployee = false;
                }
                else
                {
                    Console.WriteLine("Error");
                    break;
                }
            }
        }
    }
}
using EmployeeRegister.Helpers;

namespace EmployeeRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee addNewEmployee = new Employee();
            bool addEmployee = true;

            Console.WriteLine("Welcome to the Employee Register");

            while (addEmployee)
            {
                string userInput = Util.StringInput("\n\nWould you like to add a new employee to the registry? (Y/N)");
                Console.Clear();

                switch (userInput)
                {
                    case "y":
                    case "Y":
                        string employeeName = Util.StringInput("\nPlease enter employee name: ");
                        uint employeeSalary = Util.IntInput("Please enter employee salary: ");
                         
                        addNewEmployee.NewEmployee(employeeName, employeeSalary);
                        Console.Clear();

                        Console.WriteLine("\nCurrently in the registry: ");
                        addNewEmployee.PrintEmployeeList();
                        break;

                    case "n":
                    case "N":
                        Console.WriteLine("Please enter any key to exit the application");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine($"\"{userInput}\" is not a valid input.");
                        break;

                }
            }
        }
    }
}
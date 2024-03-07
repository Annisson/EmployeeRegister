namespace EmployeeRegister
{
    internal class Employee
    {
        public string Name { get; set; }
        public uint Salary { get; set; }


        List<Employee> employeeList = new List<Employee>();

        public Employee()
        {

        }
        public Employee(string name, uint salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public void NewEmployee(string name, uint salary)
        {
            employeeList.Add(new Employee(name, salary));
        }

        public void PrintEmployeeList()
        {

            foreach (Employee item in employeeList)
            {
                Console.Write("\nEmployee name and salary: {0}, {1:C}", item.Name, item.Salary);
            }

        }

    }
}
using System;

internal class Program
{
    public enum Vacancies
    {
        Manager,
        Clerk,
        IT,
        Sales
    }

    public struct Employee
    {
        public string Name { get; set; }
        public Vacancies Vacancy { get; set; }
        private int[] employmentDate;
        public int[] EmploymentDate
        {
            get
            {
                return employmentDate;
            }
            set
            {
                if (value.Length == 3)
                {
                    employmentDate = value; 
                }
                else
                {
                    throw new ArgumentException("EmploymentDate должен быть массивом из трех элементов");
                }
            }
        }
        public int Salary { get; set; }
    }

    static void Main(string[] args)
    {
        Employee newEmployee = new Employee();
        newEmployee.Name = "Адылханов Олжас";
        newEmployee.Vacancy = Vacancies.IT;
        newEmployee.Salary = 50000;
        newEmployee.EmploymentDate = new int[] { 2023, 11, 19 };

        Console.WriteLine("Сотрудник:");
        Console.WriteLine($"Имя: {newEmployee.Name}");
        Console.WriteLine($"Должность: {newEmployee.Vacancy}");
        Console.WriteLine($"Заработная плата: {newEmployee.Salary}");
        Console.WriteLine($"Начало работы: {string.Join("-", newEmployee.EmploymentDate)}");
    }
}

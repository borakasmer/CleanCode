using System;
using System.Collections.Generic;

namespace ExtractMethod
{
    enum Department
    {
        IT = 1,
        HumanResource = 2,
        System = 3,
        Officer = 4
    }
    enum Gender
    {
        Male,
        Female
    }
    class Person
    {
        public int Identity;
        public String Name;
        public double Salary;
        public int Department;
        public Gender Gender;
        public Person(int _identity, string name, float _salary, Department _department, Gender _gender)
        {
            this.Identity = _identity;
            this.Name = name;
            this.Salary = _salary;
            this.Department = (int)_department;
            this.Gender = _gender;
        }
    }
    class Program2
    {
        static void Main2(string[] args)
        {
            List<Person> listPerson = new List<Person>();
            listPerson.AddRange(new List<Person>() {
                new Person(1, "Test User1", 5500, Department.HumanResource,Gender.Male),
                new Person(2, "Test User2", 6500, Department.Officer,Gender.Female),
                new Person(3, "Test User3", 7500, Department.IT,Gender.Female)
            });
            CalculateSalaryIncrease(ref listPerson);

            foreach (Person person in listPerson)
            {
                Console.WriteLine($"User Name:{person.Name} Sallary:{person.Salary} Departmant:{(Department)person.Department}");
            }
        }

        public static void CalculateSalaryIncrease(ref List<Person> personList)
        {
            foreach (Person person in personList)
            {
                switch ((Department)person.Department)
                {
                    case Department.IT:
                        {
                            person.Salary = person.Salary * 1.1;
                            break;
                        }
                    case Department.HumanResource:
                        {
                            person.Salary = person.Salary * 1.2;
                            break;
                        }
                    case Department.System:
                        {
                            person.Salary = person.Salary * 1;
                            break;
                        }
                    case Department.Officer:
                        {
                            person.Salary = person.Salary * 1.3;
                            break;
                        }
                }
                person.Name = person.Gender == Gender.Male ? $"Mr.{person.Name}" : $"Ms.{person.Name}";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPerson = new List<Person>();
            listPerson.AddRange(new List<Person>() {
                new Person(1, "Test User1", 5500, Department.HumanResource,Gender.Male),
                new Person(2, "Test User2", 6500, Department.Officer,Gender.Female),
                new Person(3, "Test User3", 7500, Department.IT,Gender.Female)
            });

            CalculateSalaryIncrease(ref listPerson);

            foreach (Person person in listPerson)
            {
                Console.WriteLine($"User Name:{person.Name} Sallary:{person.Salary} Departmant:{(Department)person.Department}");
            }
        }
        public static void CalculateSalaryIncrease(ref List<Person> personList)
        {
            foreach (Person person in personList)
            {
                double sallaryRate = GetSalaryRatebyDepartment((Department)person.Department);
                person.Salary = CalculateNewSallaryWithRate(person.Salary, sallaryRate);
                person.Name = AppendTagToNameByGender(person.Name, person.Gender);
            }
        }

        public static string AppendTagToNameByGender(string name, Gender gender)
        {
            return gender == Gender.Male ? $"Mr.{name}" : $"Ms.{name}";
        }

        public static double CalculateNewSallaryWithRate(double salary, double rate)
        {
            return salary * rate;
        }

        public static double GetSalaryRatebyDepartment(Department department)
        {
            switch (department)
            {
                case Department.IT:
                    {
                        return 1.1;
                    }
                case Department.HumanResource:
                    {
                        return 1.2;
                    }
                case Department.System:
                    {
                        return 1;
                    }
                case Department.Officer:
                    {
                        return 1.3;
                    }
            }
            return 1;
        }
    }
}

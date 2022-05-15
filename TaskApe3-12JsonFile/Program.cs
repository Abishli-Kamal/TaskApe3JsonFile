
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace TaskApe3_12JsonFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee { Id = 1, Name = "Ali", Surname = "Abishli", Age = 20 };
            Employee employee1 = new Employee { Id = 1, Name = "A", Surname = "Abishli", Age = 20 };
            Employee employee2 = new Employee { Id = 1, Name = "B", Surname = "Abishli", Age = 20 };
            Employee employee3 = new Employee { Id = 1, Name = "C", Surname = "Abishli", Age = 20 };



            Departament departament = new Departament
            {
                Name = "Kafedra",
                Employees = new List<Employee>()
                {
                    employee1, employee2, employee3
                },
            };

            var dep = JsonConvert.SerializeObject(departament);

            using (StreamWriter sw = new StreamWriter(@"C:\Users\user\Desktop\TaskApe3-12JsonFile\TaskApe3-12JsonFile\jsconfig1.json"))
            {
                sw.WriteLine(dep);
            };

            string result;
            using (StreamReader sr = new StreamReader(@"C:\Users\user\Desktop\TaskApe3-12JsonFile\TaskApe3-12JsonFile\jsconfig1.json"))
            {
                result = sr.ReadLine();
            }

            Departament depr = JsonConvert.DeserializeObject<Departament>(result);

            foreach (var item in depr.Employees)
            {
                Console.WriteLine(item.Age);
            }

        }
    }
}

namespace LinqExamples_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = Data.GetEmployees();
            List<Department> departments = Data.GetDepartments();

            //var results = employees.Select(e => new
            //{
            //    FullName = e.FirstName + " " + e.LastName,  
            //    e.AnnualSalary
            //}).Where(e => e.AnnualSalary > 40000m);

            //var results = from emp in employees
            //             where emp.AnnualSalary > 30000m
            //             select new { FullName = emp.FirstName + " " + emp.LastName, emp.AnnualSalary };

            //foreach(var result in results) { 
            //    Console.WriteLine(result.FullName);
            //    Console.WriteLine(result.AnnualSalary);
            //}

            //Inner Join LINQ Operator
            //var joinedResult = departments.Join(employees, department => department.Id, employee => employee.DepartmentId, (department, employee) => new { employee.AnnualSalary, department.LongName, FullName = employee.FirstName + " " + employee.LastName,  });

            //var joinedResult = from employee in employees
            //                   join department in departments
            //                   on employee.DepartmentId equals department.Id
            //                   select new
            //                   {
            //                       FullName = employee.FirstName + " " + employee.LastName,
            //                       employee.AnnualSalary,
            //                       department.LongName
            //                   };

            //foreach(var join in joinedResult)
            //{
            //    Console.WriteLine(join.FullName);
            //    Console.WriteLine(join.AnnualSalary);
            //    Console.WriteLine(join.LongName);
            //}


            //Group Join LINQ Operator
            //var groupJoinResults = departments.GroupJoin(employees, department => department.Id, employee => employee.DepartmentId, (department, employeeGroup) => new { Employees = employeeGroup, department.LongName  });

            //foreach(var group in groupJoinResults)
            //{
            //    Console.WriteLine(group.LongName);
            //    foreach(var employee in group.Employees)
            //    {
            //        Console.WriteLine(employee.FirstName + " " + employee.LastName);
            //    }
            //}

            var groupJoinResults = from department in departments
                                   join employee in employees 
                                   on department.Id equals employee.DepartmentId
                                   into employeeGroup
                                   select new
                                   {
                                       department.LongName,
                                       Employees = employeeGroup,
                                   };

            foreach (var group in groupJoinResults)
            {
                Console.WriteLine(group.LongName);
                foreach (var employee in group.Employees)
                {
                    Console.WriteLine(employee.FirstName + " " + employee.LastName);
                }
            }

        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal AnnualSalary { get; set; }
        public bool IsManager { get; set; }
        public int DepartmentId { get; set; }
    }

    public class Department
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
    }

    public static class Data
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            Employee employee = new Employee
            {
                Id = 1,
                FirstName = "Bob",
                LastName = "Jones",
                AnnualSalary = 60000.3m,
                IsManager = true,
                DepartmentId = 1
            };
            employees.Add(employee);
            employee = new Employee
            {
                Id = 2,
                FirstName = "Sarah",
                LastName = "Jameson",
                AnnualSalary = 80000.1m,
                IsManager = true,
                DepartmentId = 2
            };
            employees.Add(employee);
            employee = new Employee
            {
                Id = 3,
                FirstName = "Douglas",
                LastName = "Roberts",
                AnnualSalary = 40000.2m,
                IsManager = false,
                DepartmentId = 2
            };
            employees.Add(employee);
            employee = new Employee
            {
                Id = 4,
                FirstName = "Jane",
                LastName = "Stevens",
                AnnualSalary = 30000.2m,
                IsManager = false,
                DepartmentId = 3
            };
            employees.Add(employee);

            return employees;
        }

        public static List<Department> GetDepartments()
        {
            List<Department> departments = new List<Department>();

            Department department = new Department
            {
                Id = 1,
                ShortName = "HR",
                LongName = "Human Resources"
            };
            departments.Add(department);
            department = new Department
            {
                Id = 2,
                ShortName = "FN",
                LongName = "Finance"
            };
            departments.Add(department);
            department = new Department
            {
                Id = 3,
                ShortName = "TE",
                LongName = "Technology"
            };
            departments.Add(department);

            return departments;
        }

    }
}




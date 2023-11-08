namespace LINQExamples_2
{
    //Sorting Operators(OrderBy, OrderByDescending, ThenBy, ThenByDescending)
    //Grouping Operators(GroupBy, ToLookUp)
    //Quantifier Operators(All, Any, Contains)
    //Filtering Operators(OfType, Where)
    //Element Operators(ElementAt, ElementAtOrDefault, First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault)
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = Data.GetEmployees();
            List<Department> departmentList = Data.GetDepartments();

            //Sorting Operations
            //OrderBy
            //var result = employeeList.Join(departmentList, e=>e.DepartmentId, d=>d.Id, (emp, dept) => new
            //{
            //    Id = emp.Id,
            //    FirstName = emp.FirstName,
            //    LastName = emp.LastName,
            //    AnnualSalary = emp.AnnualSalary,
            //    DepartmentId = emp.DepartmentId,
            //    DepartmentName = dept.LongName
            //}).OrderBy(re => re.FirstName);

            //var result = employeeList.Join(departmentList, e => e.DepartmentId, d => d.Id, (emp, dept) => new
            //{
            //    Id = emp.Id,
            //    FirstName = emp.FirstName,
            //    LastName = emp.LastName,
            //    AnnualSalary = emp.AnnualSalary,
            //    DepartmentId = emp.DepartmentId,
            //    DepartmentName = dept.LongName
            //}).OrderByDescending(re => re.FirstName);

            ////Fluent API Syntax
            //var result = employeeList.Join(departmentList, e => e.DepartmentId, d => d.Id, (emp, dept) => new
            //{
            //    Id = emp.Id,
            //    FirstName = emp.FirstName,
            //    LastName = emp.LastName,
            //    AnnualSalary = emp.AnnualSalary,
            //    DepartmentId = emp.DepartmentId,
            //    DepartmentName = dept.LongName
            //}).OrderBy(re => re.DepartmentId).ThenByDescending(or => or.FirstName);

            ////Query Expression Syntax
            //var result = from employee in employeeList
            //             join department in departmentList
            //             on employee.DepartmentId equals department.Id
            //             orderby employee.DepartmentId descending, employee.Id
            //             select new
            //             {
            //                 Id = employee.Id,
            //                 FirstName = employee.FirstName,
            //                 LastName = employee.LastName,
            //                 AnnualSalary = employee.AnnualSalary,
            //                 DepartmentName = department.LongName
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Id: {item.Id}");
            //    Console.WriteLine($"First Name: {item.FirstName}");
            //    Console.WriteLine($"Last Name: {item.LastName}");
            //    Console.WriteLine($"Annual Salary: {item.AnnualSalary}");
            //    Console.WriteLine($"DepartmentName: {item.DepartmentName}");
            //}

            //Grouping Operators

            ////GroupBy
            //var groupResult = from employee in employeeList
            //                  orderby employee.DepartmentId descending
            //                  group employee by employee.DepartmentId;

            ////Method syntax
            //var groupResult = employeeList.OrderByDescending(em => em.FirstName).GroupBy(e => e.DepartmentId);

            ////ToLookUp Operator
            //var groupResult = employeeList.ToLookup(employee => employee.DepartmentId);

            //EXECUTION OF THE GroupBy OPERATION IS DEFERRED
            //EXECUTION OF THE ToLookup OPERATION IS IMMEDIATE

            //foreach (var empGroup in groupResult)
            //{
            //    Console.WriteLine(empGroup.Key);
            //    foreach (var emp in empGroup)
            //    {
            //        Console.WriteLine(emp.FirstName);
            //    }
            //}

            ////Quantifier Operators
            //var compareAnnualSalary = 20000;

            ////All Operator
            //bool isTrueAll = employeeList.All(employee => employee.AnnualSalary > compareAnnualSalary);

            //if (isTrueAll)
            //{
            //    Console.WriteLine($"All employees have an annual salary greater than {compareAnnualSalary}");
            //}
            //else Console.WriteLine($"Not all employees have an annual salary above {compareAnnualSalary}");

            //bool isTrueAny = employeeList.Any(employee => employee.AnnualSalary < 10000);
            //if (isTrueAny)
            //{
            //    Console.WriteLine($"At least one employee have an annual salary less than 10000");
            //}
            //else Console.WriteLine("None of the employee have an annual salary less than 10000.");

            //Contains Operator
            

            //Filter Operator

            //Element Operators
            

            //ElementAt 
            //var seondIndexEmployee = employeeList.ElementAt(2);
            //Console.WriteLine(seondIndexEmployee.FirstName);

            //Exception thrown
            //var eighthIndexEmployee = employeeList.ElementAt(8);

            //ElementAtOrDefault
            //No Exception thrown
            //var eighthIndexEmployee = employeeList.ElementAtOrDefault(8);
            //if(eighthIndexEmployee != null)
            //{
            //    Console.WriteLine(eighthIndexEmployee.FirstName);
            //}

            //First
            var firstEmployee = employeeList.First();
            Console.WriteLine(firstEmployee.FirstName);

            var firstSarahEmployee = employeeList.First(e => e.FirstName == "Sarah");
            Console.WriteLine($"{firstSarahEmployee.FirstName} {firstSarahEmployee.LastName}");

            //Exception
            //var firstJamesEmployee = employeeList.First(e => e.FirstName == "James");

            var firstJamesEmployee = employeeList.FirstOrDefault(e => e.FirstName == "James");
            Console.WriteLine(firstJamesEmployee == null);

            //Single
            //Returns only one element
            //Throws an exception if there are more than on elements matching the condition.

            //SingleOrDefault
            //Returns only one element
            //Returns default value of the datatype if there are more than on elements matching the condition.




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
                    DepartmentId = 1
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
}
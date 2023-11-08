using System.Collections;

namespace LINQExamples_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = Data.GetEmployees();
            List<Department> departmentList = Data.GetDepartments();

            ////Equality Operator
            ////Sequence Equal
            //var integerList1 = new List<int> { 1, 2, 3, 4, 5, 6 };
            //var integerList2 = new List<int> { 1, 2, 3, 4, 5, 6 };
            //bool isEqual = integerList1.SequenceEqual(integerList2);
            //Console.WriteLine(isEqual);

            //var compareEmployeeList = Data.GetEmployees();
            //bool isEmployeeListEqual = compareEmployeeList.SequenceEqual(employeeList);
            //Console.WriteLine(isEmployeeListEqual);



            ////Concat Operator
            //List<int> integerList1 = new List<int> { 1, 2, 3, 4, 5, 6 };
            //List<int> integerList2 = new List<int> { 7, 8, 9, 10 };
            //var concatenatedList = integerList1.Concat(integerList2);
            //foreach(var item in concatenatedList)
            //{
            //    Console.WriteLine(item);
            //}

            //var employeeList2 = new List<Employee> { new Employee { Id = 7, FirstName = "Tony", LastName = "Stark" } };
            //var concatenatedEmployee = employeeList.Concat(employeeList2);
            //foreach(var item in concatenatedEmployee)
            //{
            //    Console.WriteLine(item.FirstName + " " + item.LastName);    
            //}


            //Aggregate Operators -  Aggregate, Average, Count, Sum, Max
            //decimal totalAnnualSalary = employeeList.Aggregate<Employee, decimal>(0, (acc, e) =>
            //{
            //    var bonus = e.IsManager ? 0.04m : 0.02m;

            //    acc += e.AnnualSalary + (e.AnnualSalary * bonus);

            //    return acc;
            //});

            //Console.WriteLine(totalAnnualSalary);

            ////Average
            //decimal averageSalary = employeeList.Where(e => e.DepartmentId == 1).Average(e => e.AnnualSalary);
            //Console.WriteLine(averageSalary);

            ////Count
            //decimal NoOfEmployees = employeeList.Count();
            //Console.WriteLine(NoOfEmployees);

            ////Sum
            //decimal totalSalaryWithoutBonus = employeeList.Sum(e => e.AnnualSalary);
            //Console.WriteLine(totalSalaryWithoutBonus);

            ////Max
            //decimal HighestEmployeeSalary = employeeList.Max(e => e.AnnualSalary);
            //Console.WriteLine(HighestEmployeeSalary);

            ////Generation Operators - DefaultIfEmpty, Empty, Range, Repeat

            ////DefaultIfEmpty
            ////It is used to return a new IEnumerable collection or the default value of the relevant collection type if it's empty
            //List<int> intList = new List<int>();
            //var newList = intList.DefaultIfEmpty();
            //Console.WriteLine(newList);

            //List<Employee> employees = new List<Employee>();
            //var newEmployeeList = employees.DefaultIfEmpty(new Employee { Id = 0 });
            //var result = newEmployeeList.ElementAt(0);
            //if (result.Id == 0) Console.WriteLine("No Employee exist");


            ////Empty
            //var emptyEmployeeCollection = Enumerable.Empty<Employee>();

            ////Range
            ////Used to return a collection of values that are within a specified range.
            //var intCollection = Enumerable.Range(25, 20);
            //foreach(var item in intCollection) { Console.WriteLine(item); }

            ////Repeat
            //var strCollection = Enumerable.Repeat("I want this to be repeated 10 times", 10);
            //foreach(string str in strCollection) { Console.WriteLine(str); }



            ////Set Operators - Distinct, Except, Intersect and Union

            ////Distinct Operator
            //List<int> integerList = new List<int> { 1, 1, 2, 1, 3, 4, 2, 1, 3, 5, 7, 6, 6, 7, 6, 7, 3 };
            //var distinctList = integerList.Distinct();
            //foreach(var item in distinctList) { Console.WriteLine(item); }

            ////Except
            ///first but not second
            //List<int> integerList1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> integerList2 = new List<int> { 2,3,4 };
            //var exceptedList = integerList1.Except(integerList2);

            //foreach(var item in exceptedList) { Console.WriteLine(item); }

            ////Intersect Operator and Union Operator
            //List<int> integerList1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> integerList2 = new List<int> { 2, 3, 4, 11, 12, 13 };
            //var results = integerList1.Intersect(integerList2);
            //var unionResults = integerList1.Union(integerList2);
            //foreach (var item in results)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in unionResults)
            //{
            //    Console.WriteLine(item);
            //}



            ////Partitioning Operators - Skip, SkipWhile, Take, TakeWhile

            ////Skip Operator
            //var skippedResult = employeeList.Skip(1);
            //foreach(var item in skippedResult) { Console.WriteLine(item.FirstName + " " + item.LastName); }


            ////SkipWhile Operator
            //var skippedResult = employeeList.SkipWhile(e => e.AnnualSalary > 50000);
            //foreach (var item in skippedResult) { Console.WriteLine(item.FirstName + " " + item.LastName); }

            //Take Operator
            //var results = employeeList.Take(2);
            //foreach (var item in results) { Console.WriteLine(item.FirstName + " " + item.LastName); }

            ////TakeWhile Operator
            ////TakeWhile vs where
            ////Takewhile stops the moment the condition is false. Where continues.
            //var results = employeeList.TakeWhile(e => e.AnnualSalary > 50000);
            //foreach (var item in results) { Console.WriteLine(item.FirstName + " " + item.LastName); }

            ////Conversion Operator - ToList, ToArray, ToDictionary

            ////ToList
            //List<Employee> results = (from employee in employeeList
            //              where employee.AnnualSalary > 50000
            //              select employee)
            //              .ToList();

            ////ToDictionary
            //Dictionary<int, Employee> results = (from e in employeeList
            //                                     where e.AnnualSalary < 50000
            //                                     select e)
            //                                    .ToDictionary<Employee, int>(e => e.Id);
            //Console.WriteLine(results);


            ////Let and Into clauses
            ////You can use let to store the result of a sub-expression in order to use it in subsequent clauses.


            ////Let
            //var results = from emp in employeeList
            //              let Intials = emp.FirstName.Substring(0, 1) + emp.LastName.Substring(0, 1)
            //              let AnnualSalaryPlusBonus = emp.IsManager ? (emp.AnnualSalary + emp.AnnualSalary * 0.04m) : (emp.AnnualSalary + emp.AnnualSalary * 0.02m)
            //              where Intials == "JS" || Intials == "SJ" && AnnualSalaryPlusBonus > 50000
            //              select emp;

            //foreach (var item in results) Console.WriteLine(item.FirstName + " " + item.LastName);


            ////Into
            //var results = from emp in employeeList
            //              where emp.AnnualSalary > 50000
            //              select emp
            //              into HighEarners
            //              where HighEarners.IsManager == true
            //              select HighEarners;

            //foreach (var result in results) { Console.WriteLine(result.FirstName + " " + result.LastName); }


            ////Projection Operator - Select and SelectMany
            
            ////Select
            
            
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
                DepartmentId = 2
            };
            employees.Add(employee);
            employee = new Employee
            {
                Id = 2,
                FirstName = "Sarah",
                LastName = "Jameson",
                AnnualSalary = 80000.1m,
                IsManager = true,
                DepartmentId = 3
            };
            employees.Add(employee);
            employee = new Employee
            {
                Id = 3,
                FirstName = "Douglas",
                LastName = "Roberts",
                AnnualSalary = 40000.2m,
                IsManager = false,
                DepartmentId = 1
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
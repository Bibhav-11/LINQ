using TCPData;
using TCPExtensions;

//List<Employee> employeeList = Data.GetEmployees();
////using anonymous function i.e. lambda expression
//var filteredList = employeeList.Filter(employee => employee.IsManager == true);

//foreach(var employee in filteredList)
//{
//    Console.WriteLine(employee.FirstName);
//}

List<Employee> employeeList = Data.GetEmployees();
List<Department> departmentList = Data.GetDepartments();

var joinedEmployeeDepartment = from emp in employeeList
                               join dept in departmentList
                               on emp.DepartmentId equals dept.Id
                               select new
                               {
                                   FirstName = emp.FirstName,
                                   LastName = emp.LastName,
                                   Department = dept.LongName
                               };

foreach(var join in joinedEmployeeDepartment)
{
    Console.WriteLine($"FirstName: {join.FirstName}");
    Console.WriteLine($"Last Name: {join.LastName}");
    Console.WriteLine($"FirstName: {join.Department}");
}
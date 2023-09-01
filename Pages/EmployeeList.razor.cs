using Assignment.Models;

namespace Assignment.Pages
{
    public partial class EmployeeList
    {
        List<Employee> employeeList;

        protected override async Task OnInitializedAsync()
        {
            employeeList = await Task.Run(() => employeesservice.GetAllEmployees());
        }
    }
}

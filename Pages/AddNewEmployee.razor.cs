using Assignment.Models;

namespace Assignment.Pages
{
    public partial class AddNewEmployee
    {
       Employee employee = new Employee();
    protected async void CreateEmployee()
    {
        await employeeService.InsertEmployee(employee);
        NavigationManager.NavigateTo("EmployeesList");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("EmployeesList");
    }
    }
}

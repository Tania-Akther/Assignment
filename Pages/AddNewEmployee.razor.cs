using Assignment.Models;
using Microsoft.AspNetCore.Components;

namespace Assignment.Pages
{
    public partial class AddNewEmployee
    {
        Employee employee = new Employee();
        List<Company> companies = new List<Company>();
        List<Department> departments = new List<Department>();
        protected async void CreateEmployee()
        {
            await employeeService.InsertEmployee(employee);
            NavigationManager.NavigateTo("EmployeesList");
        }
        void Cancel()
        {
            NavigationManager.NavigateTo("EmployeesList");
        }
        protected override async Task OnInitializedAsync()
        {
            companies = await employeeService.GetAllCompanies(); 
        }
        async Task LoadDepartmentList(ChangeEventArgs e)
        {
            //int selectedCompanyId = Convert.ToInt32(e.Value);
            //departments = await employeeService.GetAllDepartments(selectedCompanyId);
            Console.WriteLine("test");
        }
        //async void LoadDepartmentList()
        //{
        //    if (employee.CompanyID != 0) 
        //    {
        //        departments = await employeeService.GetAllDepartments(employee.CompanyID);
        //    }
        //    else
        //    {
        //        departments.Clear();
        //    }
        //}
    }
}

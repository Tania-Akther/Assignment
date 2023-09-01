using Assignment.Models;
using Microsoft.AspNetCore.Components;

namespace Assignment.Pages
{
    public partial class EditEmployee
    {
        [Parameter]
        public string Id { get; set; }
        Employee obj = new Employee();
        protected override async Task OnInitializedAsync()
        {
            obj = await Task.Run(() => employeeService.GetEmployeeById(Convert.ToInt32(Id)));
        }
        protected async void UpdateEmployee()
        {
            await employeeService.UpdateEmployee(obj);
            NavigationManager.NavigateTo("EmployeesList");
        }
        void Cancel()
        {
            NavigationManager.NavigateTo("EmployeesList");
        }
    }
}

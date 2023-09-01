using Assignment.Context;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Models
{
    public class EmployeeService
    {
        public readonly ApplicationDbContext _applicationDbContext;
        public EmployeeService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        //Get Company List
        public async Task<List<Company>> GetAllCompanies()
        {
            return await _applicationDbContext.Companies.ToListAsync();
        }
        //Get Department List
        public async Task<List<Department>> GetAllDepartments(int companyId)
        {
            var departments = await _applicationDbContext.Departments
                .Where(d => d.CompanyID == companyId)
                .ToListAsync();

            return departments;
        }
        //Get Employee List
        public async Task<List<Employee>> GetAllEmployees()
        {
            return await _applicationDbContext.Employees.ToListAsync(); 
        }
        //Add  Employees
        public async Task<bool> InsertEmployee(Employee employee)
        {
            await _applicationDbContext.Employees.AddAsync(employee);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Get Employee By Id  
        public async Task<Employee> GetEmployeeById(int employeeId)
        {
            Employee employee = await _applicationDbContext.Employees.FirstOrDefaultAsync(c => c.EmployeeId.Equals(employeeId));
            return employee;
        }

        //Update Employee
        public async Task<bool> UpdateEmployee(Employee employee)
        {
            _applicationDbContext.Employees.Update(employee);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Delete Employee
        public async Task<bool> DeleteEmployee(Employee employee)
        {
            _applicationDbContext.Employees.Remove(employee);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
    }
}

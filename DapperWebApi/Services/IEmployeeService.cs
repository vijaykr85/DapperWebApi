namespace DapperWebApi.Services
{
    public interface IEmployeeService
    {
        Task<bool> CreateEmployee(Employee employee);
        Task<List<Employee>> GetEmployee();
        Task<Employee> UpdateEmployee(Employee employee);
        Task<bool> DeleteEmployee(int key);
    }
}

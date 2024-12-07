using CSSSDF_FINALS.Models;

namespace CSSSDF_FINALS.Managers
{
    public interface Service
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        void AddEmployee(Employee employee);
        void UpdateEmployee(int id, Employee employee);
        void DeleteEmployee(int id);
    }
}

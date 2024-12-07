using CSSSDF_FINALS.Models;

namespace CSSSDF_FINALS.Managers
{
    //Note to self: Manager handles the interaction with system to database.
    //Note to self: Controller handles the interation between the website and the service?
    //Naka inherit lang po siya sa service pero di po nagagamit actual methods dun. Dbcontext po kasi ginamit.
    public class Manager : Service
    {
        void invalid_id_message()
        {
            Console.WriteLine("Employee ID Not Found!");
        }

        void operation_success_message()
        {
            Console.WriteLine("Operation Performed Succesfully!");
        }
        private readonly EmployeeContext _context;

        public Manager(EmployeeContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            foreach (var employee in _context.Employees)
            {
                if (id == employee.EmployeeId)
                {
                    return employee;
                }
            }
            invalid_id_message();
            return null;
        }

        public void AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }
        public void UpdateEmployee(int id, Employee employee)
        {
            foreach (var e in _context.Employees)
            {
                if (id == e.EmployeeId)
                {
                    e.FirstName = employee.FirstName;
                    e.LastName = employee.LastName;
                    e.Age = employee.Age;
                    e.Address = employee.Address;
                    e.Position = employee.Position;
                    e.Course = employee.Course;
                    e.Salary = employee.Salary;
                    e.HireDate = employee.HireDate;
                    e.Department = employee.Department;
                    e.Email = employee.Email;
                    e.PhoneNumber = employee.PhoneNumber;
                    _context.SaveChanges();
                    return;
                }
            }
            invalid_id_message();
        }
        public void DeleteEmployee(int id)
        {
            foreach (var employee in _context.Employees)
            {
                if (id == employee.EmployeeId)
                {
                    _context.Employees.Remove(employee);
                    operation_success_message();
                    _context.SaveChanges();
                }
            }
        }
    }
}

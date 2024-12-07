namespace CSSSDF_FINALS.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public string Course {  get; set; }
        //Senior, Junior, Etc.
        public string Position { get; set; }
        public double Salary { get; set; }
        public int EmployeeId { get; set; }
        public DateTime HireDate { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}

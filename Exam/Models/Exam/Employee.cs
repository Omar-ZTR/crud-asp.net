namespace Exam.Models.Exam
{
    public class Employee
    {
        public int? EmployeeId { get; set; }
        public string EmployeeName { get; set; } = string.Empty;
        public string? ImageUser { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }
        public DateTime HiringDate { get; set; }
        public string NationalId { get; set; } = string.Empty;
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

    }
}

namespace UniversityLabEF
{
    // Student from Week 6: inherits from Person.
    public class Student : Person
    {
        public string StudentId { get; set; }
        public string Course { get; set; }
        public Department Department { get; set; }

        // Needed to add new rows in a grid.
        public Student()
        {
        }

        public Student(string nationalId, string name, DateTime dateOfBirth,
                       string phoneNumber, string address, string studentId, string course)
            : base(nationalId, name, dateOfBirth, phoneNumber, address)
        {
            StudentId = studentId;
            Course = course;
        }

        public override string GetRole()
        {
            return "Student";
        }
    }
}

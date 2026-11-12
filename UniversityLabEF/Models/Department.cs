namespace UniversityLabEF
{
    // Department from Week 6: aggregates students.
    public class Department
    {
        public int DepartmentId { get; set; }   // new: the primary key, for EF
        public string Name { get; set; }
        public string School { get; set; }
        public List<Student> Students { get; } = new List<Student>();

        public Department(string name, string school)
        {
            Name = name;
            School = school;
        }

        // Shows the name wherever a Department is displayed, e.g. in a grid.
        public override string ToString()
        {
            return Name;
        }

        public void AddStudent(Student s)
        {
            if (!Students.Contains(s))
            {
                Students.Add(s);
                s.Department = this;
            }
        }
    }
}

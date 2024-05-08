namespace BaseClass_Ex
{
    public partial class Person
    {
        public class Student : Person
        {
            public string StudentID { get; set; }
            public Student(string name, string family, string studentId) : base(name, family)
            {
                StudentID = studentId;
            }
            public override sealed void Introduce()
            {
                Console.WriteLine($"My Name is {Name} And My Student ID is {StudentID}");
            }
        }
    }
}

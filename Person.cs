using static BaseClass_Ex.Person;

namespace BaseClass_Ex
{
    public partial class Person
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public Person(string name, string family)
        {
            Name = name;
            Family = family;
        }
        public virtual void Introduce()
        {
            Console.WriteLine($"My Name is {Name} And My LastName is {Family}");
        }
    }
}

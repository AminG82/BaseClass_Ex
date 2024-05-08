//Base keword
using BaseClass_Ex;
using static BaseClass_Ex.Person;



Console.WriteLine("Hello, World!");

Student s = new Student("Amin" , "G82" , "000123");
Person p = new Person("Amin", "G82");
p.Introduce();
s.Introduce();

Console.ReadKey();
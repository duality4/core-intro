namespace CoreIntro.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public Person(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}
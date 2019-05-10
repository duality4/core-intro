namespace CoreIntro.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public Person(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
        public Person()
        {

        }
    }
}
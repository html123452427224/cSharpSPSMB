using OopExamples.Interfaces;

namespace OopExamples.Implementations
{
    public class Person : IPerson
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Person Name: {Name}";
        }
    }
}
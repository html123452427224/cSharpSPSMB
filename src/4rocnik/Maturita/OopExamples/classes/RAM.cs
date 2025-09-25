using OopExamples.Interfaces;

namespace OopExamples.Implementations
{
    public class RAM : IRAM
    {
        public string Name { get; set; }

        public RAM(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"RAM Name: {Name}";
        }
    }
}
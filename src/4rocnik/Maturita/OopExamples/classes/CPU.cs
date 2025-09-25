using OopExamples.Interfaces;

namespace OopExamples.Implementations
{
    public class CPU : ICPU
    {
        public string Name { get; set; }

        public CPU(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"CPU: {Name}";
        }
    }
}
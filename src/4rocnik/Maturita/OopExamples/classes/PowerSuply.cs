using OopExamples.Interfaces;

namespace OopExamples.Implementations
{
    public class PowerSupply : IPowerSupply
    {
        public string Name { get; set; }

        public PowerSupply(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Power Supply: {Name}";
        }
    }
}
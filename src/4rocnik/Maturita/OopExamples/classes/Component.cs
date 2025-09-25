using OopExamples.Interfaces;

namespace OopExamples.Implementations
{
    public class Component : IComponent
    {
        public string Name { get; set; }

        public Component(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Component Name: {Name}";
        }
    }
}
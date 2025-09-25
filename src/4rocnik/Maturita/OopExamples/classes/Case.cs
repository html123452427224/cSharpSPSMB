using OopExamples.Interfaces;

namespace OopExamples.Implementations
{
    public class Case : ICase
    {
        public string Name { get; set; }

        public Case(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Case Name: {Name}";
        }
    }
}
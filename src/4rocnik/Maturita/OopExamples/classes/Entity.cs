using OopExamples.Interfaces;

namespace OopExamples.Implementations
{
    public class Entity : IEntity
    {
        public string Name { get; set; }

        public Entity(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Entity Name: {Name}";
        }
    }
}
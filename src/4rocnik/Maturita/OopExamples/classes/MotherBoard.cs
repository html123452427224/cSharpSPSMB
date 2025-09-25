using OopExamples.Interfaces;

namespace OopExamples.Implementations
{
    public class MotherBoard : IMotherBoard
    {
        public string Name { get; set; }

        public MotherBoard(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"MotherBoard: {Name}";
        }
    }
}
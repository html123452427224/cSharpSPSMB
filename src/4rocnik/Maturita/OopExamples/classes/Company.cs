using OopExamples.Interfaces;

namespace OopExamples.Implementations
{
    public class Company : ICompany
    {
        public string Name { get; set; }
        public IPerson Owner { get; set; }

        public Company(string name, IPerson owner)
        {
            Name = name;
            Owner = owner;
        }

        public override string ToString()
        {
            return $"Company Name: {Name}, Owner: {Owner}";
        }
    }
}
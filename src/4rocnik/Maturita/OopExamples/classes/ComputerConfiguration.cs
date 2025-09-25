using OopExamples.Interfaces;

namespace OopExamples.Implementations
{
    public class ComputerConfiguration : IComputerConfiguration
    {
        public IMotherBoard MotherBoard { get; set; }
        public ICPU Cpu { get; set; }
        public IGPU Gpu { get; set; }
        public IRAM Ram { get; set; }
        public IPowerSupply PowerSupply { get; set; }
        public ICase Case { get; set; }

        public ComputerConfiguration(
            IMotherBoard motherBoard,
            ICPU cpu,
            IGPU gpu,
            IRAM ram,
            IPowerSupply powerSupply,
            ICase pcCase)
        {
            MotherBoard = motherBoard;
            Cpu = cpu;
            Gpu = gpu;
            Ram = ram;
            PowerSupply = powerSupply;
            Case = pcCase;
        }

        public override string ToString()
        {
            return $"Configuration:\n" +
                   $"- MotherBoard: {MotherBoard?.Name}\n" +
                   $"- CPU: {Cpu?.Name}\n" +
                   $"- GPU: {Gpu?.Name}\n" +
                   $"- RAM: {Ram?.Name}\n" +
                   $"- Power Supply: {PowerSupply?.Name}\n" +
                   $"- Case: {Case?.Name}";
        }
    }
}
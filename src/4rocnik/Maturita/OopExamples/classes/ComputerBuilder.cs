using System;
using OopExamples.Interfaces;

namespace OopExamples.Implementations
{
    public class ComputerBuilder : IComputerBuilder
    {
        private IMotherBoard? motherBoard;
        private ICPU? cpu;
        private IGPU? gpu;
        private IRAM? ram;
        private IPowerSupply? powerSupply;
        private ICase? pcCase;
        private IEntity? owner;

        public IComputerBuilder AddMotherBoard(IMotherBoard motherBoard)
        {
            this.motherBoard = motherBoard;
            return this;
        }

        public IComputerBuilder AddCPU(ICPU cpu)
        {
            this.cpu = cpu;
            return this;
        }

        public IComputerBuilder AddGPU(IGPU gpu)
        {
            this.gpu = gpu;
            return this;
        }

        public IComputerBuilder AddRam(IRAM ram)
        {
            this.ram = ram;
            return this;
        }

        public IComputerBuilder AddPowerSupply(IPowerSupply powerSupply)
        {
            this.powerSupply = powerSupply;
            return this;
        }

        public IComputerBuilder AddCase(ICase pcCase)
        {
            this.pcCase = pcCase;
            return this;
        }

        public ComputerBuilder SetOwner(IEntity owner)
        {
            this.owner = owner;
            return this;
        }

        public IComputer Build()
        {
            if (motherBoard == null ||
                cpu == null ||
                gpu == null ||
                ram == null ||
                powerSupply == null ||
                pcCase == null)
            {
                throw new InvalidOperationException("All components must be added before building the computer.");
            }

            if (owner == null)
            {
                throw new InvalidOperationException("Owner must be set before building the computer.");
            }

            var configuration = new ComputerConfiguration(
                motherBoard,
                cpu,
                gpu,
                ram,
                powerSupply,
                pcCase
            );

            return new Computer(
                configuration.MotherBoard,
                configuration.Cpu,
                configuration.Gpu,
                configuration.Ram,
                configuration.PowerSupply,
                configuration.Case,
                owner);
        }

        public IComputer BuildFromConfiguration(IComputerConfiguration configuration)
        {
            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));

            if (owner == null)
                throw new InvalidOperationException("Owner must be set before building the computer.");

            return new Computer(
                configuration.MotherBoard,
                configuration.Cpu,
                configuration.Gpu,
                configuration.Ram,
                configuration.PowerSupply,
                configuration.Case,
                owner);
        }
    }
}

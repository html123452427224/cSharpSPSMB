using System;
using System.Collections.Generic;
using System.Linq;
using OopExamples.Interfaces;
using OopExamples.Implementations;

namespace OopExamples.Tests
{
    public class NewComputerTests
    {
        protected IComputerConfiguration ComputerConfiguration { get; set; }
        protected IComputerBuilder Builder { get; set; }
        protected IComputer Computer { get; set; }
        protected IPerson Person { get; set; }
        protected ICompany Company { get; set; }
        protected IEnumerable<IMonitor> Monitors { get; set; }

        // Assuming these are the connectors supported by monitors
        protected GPUConnector[] MonitorConnectors => new[] { GPUConnector.HDMI, GPUConnector.DisplayPort };

        public NewComputerTests()
        {
            // Create test owner (person and company)
            Person = new Person { Name = "John Doe" };
            Company = new Company { Name = "OpenAI", Owner = Person };

            // Create dummy monitor list
            Monitors = MonitorConnectors.Select(connector => new Monitor($"Monitor-{connector}", connector)).ToList();

            // Create GPU with matching connectors
            var gpu = new GPU("Test GPU", MonitorConnectors);

            // Create other components
            var motherboard = new MotherBoard { Name = "Test Motherboard" };
            var cpu = new CPU { Name = "Test CPU" };
            var ram = new RAM { Name = "Test RAM" };
            var psu = new PowerSupply { Name = "Test PSU" };
            var pcCase = new Case { Name = "Test Case" };

            // Build configuration
            ComputerConfiguration = new ComputerConfiguration(motherboard, cpu, gpu, ram, psu, pcCase);

            // Initialize builder and computer
            Builder = new ComputerBuilder()
                .AddMotherBoard(motherboard)
                .AddCPU(cpu)
                .AddGPU(gpu)
                .AddRam(ram)
                .AddPowerSupply(psu)
                .AddCase(pcCase)
                .SetOwner(Person);

            Computer = Builder.Build();
        }

        [Fact]
        public void IsValidSetup()
        {
            Assert.NotNull(ComputerConfiguration);
            Assert.NotNull(Builder);
            Assert.NotNull(Computer);
            Assert.NotNull(Person);
            Assert.NotNull(Company);
            Assert.NotNull(Monitors);

            Assert.NotEmpty(Monitors);
            Assert.Equal(MonitorConnectors.Length, Monitors.Count());
            Assert.All(Monitors, monitor =>
                Assert.Contains(monitor.Connector, MonitorConnectors));
        }

        protected void IsValidComputer(IComputer computer)
        {
            Assert.NotNull(computer.MotherBoard);
            Assert.NotNull(computer.Gpu);
            Assert.NotNull(computer.Ram);
            Assert.NotNull(computer.PowerSupply);
            Assert.NotNull(computer.Case);
        }
    }
}

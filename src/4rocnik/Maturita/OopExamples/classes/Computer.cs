using System;
using System.Collections.Generic;
using OopExamples.Interfaces;

namespace OopExamples.Implementations
{
    public class Computer : IComputer
    {
        public IEntity Owner { get; private set; }
        public IMotherBoard MotherBoard { get; private set; }
        public ICPU Cpu { get; private set; }
        public IGPU Gpu { get; private set; }
        public IRAM Ram { get; private set; }
        public IPowerSupply PowerSupply { get; private set; }
        public ICase Case { get; private set; }
        private readonly List<IMonitor> monitors = new();

        public IMonitor[] Monitors => monitors.ToArray();

        public bool IsOn { get; private set; }

        public bool IsPersonalPC => Owner is IPerson;
        public bool IsCompanyPC => Owner is ICompany;

        public Computer(
            IMotherBoard motherBoard,
            ICPU cpu,
            IGPU gpu,
            IRAM ram,
            IPowerSupply powerSupply,
            ICase pcCase,
            IEntity owner,
            IMonitor[]? initialMonitors = null)
        {
            MotherBoard = motherBoard ?? throw new ArgumentNullException(nameof(motherBoard));
            Cpu = cpu ?? throw new ArgumentNullException(nameof(cpu));
            Gpu = gpu ?? throw new ArgumentNullException(nameof(gpu));
            Ram = ram ?? throw new ArgumentNullException(nameof(ram));
            PowerSupply = powerSupply ?? throw new ArgumentNullException(nameof(powerSupply));
            Case = pcCase ?? throw new ArgumentNullException(nameof(pcCase));
            Owner = owner ?? throw new ArgumentNullException(nameof(owner));

            if (initialMonitors != null)
                monitors.AddRange(initialMonitors);
        }

        
        public void PowerUp()
        {
            if (!IsOn)
            {
                IsOn = true;
            }
        }

        public void ShutDown()
        {
            if (IsOn)
            {
                IsOn = false;
            }
        }

        public void PressPowerButton()
        {
            if (IsOn)
                ShutDown();
            else
                PowerUp();
        }

        public void Print(string text)
        {
            if (!IsOn)
            {
                Console.WriteLine("Computer is off. Cannot print.");
                return;
            }

            foreach (var monitor in monitors)
            {
                Console.WriteLine($"Printing on monitor {monitor.Name}: {text}");
            }
        }

        public float Compute(string equation)
        {
            if (!IsOn)
            {
                Console.WriteLine("Computer is off. Cannot compute.");
                return 0;
            }

            // Very basic example, evaluate only simple equations like "1 + 2"
            try
            {
                var parts = equation.Split(' ');
                if (parts.Length != 3)
                    throw new FormatException("Invalid equation format.");

                float left = float.Parse(parts[0]);
                string op = parts[1];
                float right = float.Parse(parts[2]);

                return op switch
                {
                    "+" => left + right,
                    "-" => left - right,
                    "*" => left * right,
                    "/" => right != 0 ? left / right : throw new DivideByZeroException(),
                    _ => throw new NotSupportedException($"Operator {op} not supported."),
                };
            }
            catch
            {
                Console.WriteLine("Failed to compute the equation.");
                return 0;
            }
        }

        public IComputer BuildNewComputer(IComputerConfiguration configuration)
        {
            return new Computer(
                configuration.MotherBoard,
                configuration.Cpu,
                configuration.Gpu,
                configuration.Ram,
                configuration.PowerSupply,
                configuration.Case,
                Owner);
        }

        public void ChangeOwner(IEntity person)
        {
            if (person == null)
                throw new ArgumentNullException(nameof(person));

            Owner = person;
        }

        public void RemoveOwner()
        {
            Owner = null!;
        }

        public void AddMonitor(IMonitor monitor)
        {
            if (monitor == null) throw new ArgumentNullException(nameof(monitor));
            if (!monitors.Contains(monitor))
                monitors.Add(monitor);
        }

        public void RemoveMonitor(IMonitor monitor)
        {
            if (monitor == null) throw new ArgumentNullException(nameof(monitor));
            monitors.Remove(monitor);
        }
    }
}

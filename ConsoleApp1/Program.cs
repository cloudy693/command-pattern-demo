﻿using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var availableCommands = GetAvailableCommands();

            if (args.Length == 0) {
                PrintUsage(availableCommands);
                Console.ReadLine();
                return;
            }

            var parser = new CommandParser(availableCommands);

            var command = parser.ParseCommand(args);

            command.Execute();


        }

        private static void PrintUsage(IEnumerable<ICommandFactory> availableCommands)
        {
            foreach(var command in availableCommands)
                Console.WriteLine($"{command.CommandName}");
        }

        private static IEnumerable<ICommandFactory> GetAvailableCommands()
        {
            return new ICommandFactory[]
            {
                //new CreateOrderCommand(),
                new UpdateQuantityCommand()
                //new ShipOrderCommand()
            };
        }

    }
}

using System;
using Spectre.CommandLine;

namespace DotnetCake {
    public class BootstrapperCommand : Command<BootstrapperSettings> {
        public override int Run(BootstrapperSettings settings) {
            Console.WriteLine("It executed!");

            return 0;
        }
    }
}
using System;
using Spectre.CommandLine;

namespace DotnetCake.Commands {
    public class BuildCommand : Command<BuildCommand.Settings> {
        public sealed class Settings : CakeSettings {
            
        }
        
        public override int Run(Settings settings) {
            Console.WriteLine("Build executed!");
            return 0;
        }
    }
}
using System;
using Spectre.CommandLine;

namespace DotnetCake.Commands {
    public class InitCommand : Command<InitCommand.Settings> {
        public sealed class Settings : CakeSettings {
            
        }
        
        public override int Run(Settings settings) {
            Console.WriteLine("Init executed!");
            return 0;
        }
    }
}
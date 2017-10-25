using System;
using System.ComponentModel;
using Spectre.CommandLine;
using Spectre.CommandLine.Annotations;

namespace DotnetCake.Commands {
    public class BuildCommand : Command<BuildCommand.Settings> {
        public sealed class Settings : CakeSettings {
            [Option("-s|--script")]
            [DefaultValue("build.cake")]
            [Description("The Cake file to execute, defaults to build.cake.")]
            public string Script { get; set; }

            [Option("-t|--target")]
            [DefaultValue("Default")]
            [Description("The Cake task to target, defaults to Default.")]
            public string Target { get; set; }

            [Option("-c|--configuration")]
            [DefaultValue("Release")]
            [Description("The configuration to execute.")]
            public string Configuration { get; set; }

            [Option("-v|--verbosity")]
            [DefaultValue("Verbose")]
            [Description("The log level, defaults to verbose.")]
            public string Verbosity { get; set; }

            [Option("-r|--skipToolPacakageRestore")]
            [Description("Allows skipping Cake package restore, default is false.")]
            public bool SkipToolPackageRestore { get; set; }

            public string ScriptArgs { get; set; }
        }
        
        public override int Run(Settings settings) {
            Console.WriteLine("Build executed!");
            return 0;
        }
    }
}
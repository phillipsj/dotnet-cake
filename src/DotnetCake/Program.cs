using Microsoft.Extensions.CommandLineUtils;

namespace DotnetCake {
    class Program {
        static int Main(string[] args) {
            var commandLineApp = new CommandLineApplication(false);
            commandLineApp.HelpOption("-?|-h|--help");
            commandLineApp.FullName = "Cake bootstrapper CLI version.";
            commandLineApp.Option("-s|--script", "The Cake file to execute, defaults to build.cake.", CommandOptionType.SingleValue);
            commandLineApp.Option("-t|--target", "The Cake task to target, defaults to Default.", CommandOptionType.SingleValue);
            commandLineApp.Option("-c|--configuration", "The cake file to execute.", CommandOptionType.SingleValue);
            commandLineApp.Option("-v|--verbosity", "The log level, defaults to verbose.", CommandOptionType.SingleValue);
            commandLineApp.Option("-r|--skipToolPacakageRestore", "Allows skipping Cake package restore, default is false.", CommandOptionType.NoValue);
           
            return commandLineApp.Execute(args);
        }
    }
}


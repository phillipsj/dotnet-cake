using System;
using System.ComponentModel;
using Microsoft.Extensions.CommandLineUtils;
using Spectre.CommandLine;
using Spectre.CommandLine.Annotations;


namespace DotnetCake {
    class Program {
        static int Main(string[] args) {
            var app = new CommandApp();
            app.Configure(config => {
                config.AddProxy<BootstrapperSettings>("cake", bs => {
                    bs.SetDescription("Cross platform Cake build tools bootstrapper.");
                    bs.AddCommand<BootstrapperCommand>("bs");
                });
            });


            return app.Run(args);
        }
    }

    class CommandParser {
        private readonly CommandLineApplication _commandApp;
        private CommandArgument _command;
        private CommandOption _configurationOption;
        private CommandOption _outputOption;
        private CommandArguments _parsed;
        private CommandOption _scriptPath;
        private CommandOption _targetsToExecute;
        private CommandOption _parallelTargetExecution;

        public CommandParser(CommandLineApplication commandApp) {
            _commandApp = commandApp;
        }

        public CommandArguments Parse(string[] args) {
            _parsed = new CommandArguments();

            _commandApp.HelpOption("-?|-h|--help");
            _command = _commandApp.Argument("[arguments]", "The command to execute", true);
            if (args == null) {
                args = new string[0];
            }

            _parsed.Help = true;
            _commandApp.Execute(args);
            return _parsed;
        }

        public void ShowHelp() => _commandApp.ShowHelp();
    }

    class CommandArguments {
        public string Script { get; set; }
        public bool Help { get; set; }
    }
}


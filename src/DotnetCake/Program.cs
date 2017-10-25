using DotnetCake.Commands;
using Spectre.CommandLine;

namespace DotnetCake {
    class Program {
        static int Main(string[] args) {
            var app = new CommandApp();
            
            app.Configure(config => {
                config.AddProxy<CakeSettings>("", cake => {
                    config.AddCommand<InitCommand>("init");
                    config.AddCommand<BuildCommand>("build");
                });
            });

            return app.Run(args);
        }
    }
}


using System;
using System.IO;
using System.Linq;
using System.Net;
using Spectre.CommandLine;

namespace DotnetCake.Commands {
    public class InitCommand : Command<InitCommand.Settings> {
        private readonly string _toolsDirectory;
        private readonly string _nugetExe;
        private readonly string _cakeExe;
        private readonly string _nugetUrl;
        private readonly string _packagesConfig;
        private readonly string _packagesConfigMd5;
        
        public InitCommand() {
            _toolsDirectory = Path.Combine(Directory.GetCurrentDirectory(), "tools");
            _nugetExe = Path.Combine(_toolsDirectory, "nuget.exe");
            _cakeExe = Path.Combine(_toolsDirectory, "Cake", "Cake.exe");
            _nugetUrl = "https://dist.nuget.org/win-x86-commandline/latest/nuget.exe";
            _packagesConfig = Path.Combine(_toolsDirectory, "packages.config");
            _packagesConfigMd5 = Path.Combine(_toolsDirectory, "packages.config.md5sum");

        }
       
        
        public sealed class Settings : CakeSettings {
            
        }
        
        public override int Run(Settings settings) {
            Console.WriteLine("Init executed!");
            
            // Stepping through in a procedural way so I can then refactor.
            Console.WriteLine("Creating tools directory...");
            EnsureDirectoryExists(_toolsDirectory);

            Console.WriteLine("Downloading packages.config...");

            try {
                using (var webClient = new WebClient()) {
                    webClient.DownloadFile("http://cakebuild.net/download/bootstrapper/packages", _packagesConfig);
                }
            }
            catch (Exception e) {
                Console.WriteLine("Could not download packages.config.");
                throw;
            }

            if (string.IsNullOrEmpty(_nugetExe)) {
                
            }

            return 0;
        }

        private void EnsureDirectoryExists(string directory) {
            var directoryInfo = new DirectoryInfo(directory);
            if (!directoryInfo.Exists) {
                directoryInfo.Create();
            }
        }

        private string FindNuget() {
            Console.WriteLine("Trying to find nuget.exe in PATH...");
            var existingPaths = Environment.GetEnvironmentVariable("Path").Split(';')
                .Select(x => x.Contains(_nugetExe));

            throw new NotImplementedException();
        }
    }
}
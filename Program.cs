using System;
using Autofac;

namespace SharkLyricsGenerator
{
    public class Program
    {

#pragma warning disable CS8618
        private static IContainer Container { get; set; }
#pragma warning restore CS8618

        public static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<SharkService>().As<ISharkService>();
            builder.RegisterType<OutputService>().As<IOutputService>();
            builder.RegisterType<LyricsService>().As<ILyricsService>();
            Container = builder.Build();

            PrintLyrics();
        }

        public static void PrintLyrics()
        {
            using(var scope = Container.BeginLifetimeScope())
            {
                var lyricsService = scope.Resolve<ILyricsService>();
                var outputService = scope.Resolve<IOutputService>();

                outputService.PrintHeading(
                    $"{DateTime.Now.ToString("yyyy-MM-dd")} - Baby Shark",
                    $"Lovingly generated for you by the SharkLyricGenerator @ {DateTime.Now.ToString("hh:mmtt")}");
                lyricsService.GenerateLyrics();
            }
        }
    }
}
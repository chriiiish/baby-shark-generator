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
                lyricsService.GenerateLyrics();
            }
        }
    }
}
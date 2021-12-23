using System;
using Autofac;

namespace SharkLyricsGenerator
{
    public class Program
    {
        static void Main(string[] args){

            var sharkService = new SharkService();
            var outputService = new OutputService();
            var lyricsService = new LyricsService(sharkService, outputService);

            lyricsService.GenerateLyrics();
        }
    }
}
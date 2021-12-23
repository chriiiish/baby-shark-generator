using System;
using Autofac;

namespace ColourTeller
{
    public class Program
    {
        static void Main(string[] args){

            var colourService = new ColourService();
            var outputService = new OutputService();

            outputService.Print($"Its a whole {colourService.GetColour()} wooooooorld!");
        }
    }
}
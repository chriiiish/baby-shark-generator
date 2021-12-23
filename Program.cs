using System;
using Autofac;

namespace ColourTeller
{
    public class Program
    {
        static void Main(string[] args){

            var colourService = new ColourService();
            Console.WriteLine($"Its a whole {colourService.GetColour()} wooooooorld!");
        }
    }
}
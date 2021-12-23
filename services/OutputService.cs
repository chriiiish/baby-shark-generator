using System.Text.RegularExpressions;

namespace SharkLyricsGenerator{
    public interface IOutputService {
        void Print(string message);
        void PrintHeading(string heading, string subheading = "");
    }

    public class OutputService:IOutputService {
        public void Print(string message){
            message = Regex.Replace(message, @"[ \t]+", " "); // Replace lots of spaces/tabs with single space
            Console.WriteLine(message);
        }

        public void PrintHeading(string heading, string subheading = ""){
            heading = $" {heading} ";
            Console.WriteLine();
            Console.WriteLine(heading);
            Console.WriteLine("".PadRight(heading.Length).Replace(' ', '='));

            if(!string.IsNullOrWhiteSpace(subheading)){
                Console.WriteLine(subheading);
            }
        }
    }
}
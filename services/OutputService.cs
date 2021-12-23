using System.Text.RegularExpressions;

namespace SharkLyricsGenerator{
    public interface IOutputService {
        void Print(string message);
    }

    public class OutputService:IOutputService {
        public void Print(string message){
            message = Regex.Replace(message, @"[ \t]+", " "); // Replace lots of spaces/tabs with single space
            Console.WriteLine(message);
        }
    }
}
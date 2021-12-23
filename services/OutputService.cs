namespace ColourTeller{
    public interface IOutputService {
        public void Print(string message);
    }

    public class OutputService:IOutputService {
        public void Print(string message){
            var timestamp = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            Console.WriteLine($"[{timestamp}] {message}");
        }
    }
}
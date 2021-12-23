namespace SharkLyricsGenerator
{
    public interface ISharkService{
        string GetSharkType();
    }

    public class SharkService:ISharkService{
        public string GetSharkType(){
            return "Baby";
        }
    }
}
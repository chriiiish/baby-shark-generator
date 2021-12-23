namespace ColourTeller
{
    public interface IColourService{
        public string GetColour();
    }

    public class ColourService:IColourService{
        public string GetColour(){
            return "Blue";
        }
    }
}
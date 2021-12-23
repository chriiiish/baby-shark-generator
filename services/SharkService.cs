namespace SharkLyricsGenerator
{
    public interface ISharkService{
        string GetSharkType();
    }

    public class SharkService:ISharkService{
        private List<string> _sharkTypes = new List<string>{ "Baby", "Mummy", "Daddy", "Grandma", "Grandpa"};
        private int _listPosition = 0;
        public string GetSharkType(){
            var sharkType = _sharkTypes[_listPosition % _sharkTypes.Count]; // Circle over the list of sharkTypes
            _listPosition++;
            return sharkType;
        }
    }
}
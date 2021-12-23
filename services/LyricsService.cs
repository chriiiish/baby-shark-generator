namespace SharkLyricsGenerator
{
    public interface ILyricsService
    {
        void GenerateLyrics();
    }

    public class LyricsService:ILyricsService
    {
        private SharkService _sharkService;
        private OutputService _outputService;

        public LyricsService(SharkService sharkService, OutputService outputService)
        {
            _sharkService = sharkService;
            _outputService = outputService;
        }

        public void GenerateLyrics()
        {
            for(int i = 0; i < 5; i++)
            {
                _outputService.Print(GenerateVerse(_sharkService.GetSharkType()));
            }
        }

        private string GenerateVerse(string sharkType)
        {
            return $@"
            {sharkType} shark do-do-do-do-do-do
            {sharkType} shark do-do-do-do-do-do
            {sharkType} shark do-do-do-do-do-do
            {sharkType} shark
            ";
        }
    }
}
namespace SharkLyricsGenerator
{
    public interface ILyricsService
    {
        void GenerateLyrics();
    }

    public class LyricsService:ILyricsService
    {
        private ISharkService _sharkService;
        private IOutputService _outputService;

        public LyricsService(ISharkService sharkService, IOutputService outputService)
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
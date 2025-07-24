namespace Hangman
{
    public partial class MainPage : ContentPage
    {
        #region Fields  
        List<string> words = new List<string>()
           {
               "python",
               "javascript",
               "maui",
               "csharp",
               "mongodb",
               "sql",
               "xaml",
               "word",
               "excel",
               "powerpoint",
               "code",
               "hotreload",
               "snippets"
           };
        string answer = "";


        #endregion

        public MainPage()
        {
            InitializeComponent();
        }
    }

}

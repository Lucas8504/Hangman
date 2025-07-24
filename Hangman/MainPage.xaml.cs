using System.ComponentModel;
using System.Diagnostics;

namespace Hangman
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        #region UI Properties
        public string Spotlight
        {
            get => spotlight;
            set
            {
                spotlight = value;
                OnPropertyChanged();
            }
        }

        #endregion

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
        private string spotlight = string.Empty; // Initialize to avoid nullability warning
        List<char> guessed = new List<char>();

        #endregion

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            PickWord();
            CalculateWord(answer, guessed);
        }

        #region Game Engine
        private void PickWord()
        {
            answer =
                 words[new Random().Next(0, words.Count)];
            Debug.WriteLine(answer);
        }

        private void CalculateWord(string answer, List<char> guessed)
        {
            var temp =
                 answer.Select(x => (guessed.IndexOf(x) >= 0 ? x : '_'))
                 .ToArray();
            Spotlight = string.Join(' ', temp);

        }

        #endregion
    }

}

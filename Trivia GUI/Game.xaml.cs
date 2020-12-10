using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Trivia_GUI
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Page
    {
        string[] Question;
        string[] Answers;
        string Question1 = "What shark has been found in the Illinois River?";
        string Question2 = "What's the world's largest freshwater fish?";
        string Answer1 = "Bull Shark";
        string Answer2 = "Beluga Sturgeon";

        Random rnd;
        int selection;

        public Game()
        {
            InitializeComponent();
            Question = new string[2] { Question1, Question2 };
            Answers = new string[2] { Answer1, Answer2 };

            rnd = new Random();
            PickQuestion();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CheckForRightAnswer();
        }

        void PickQuestion()
        {
            selection = rnd.Next(0, Question.Length);
            term.Content = Question[selection];
        }
        void CheckForRightAnswer()
        {
            if (useranswer.Text == Answers[selection])
            {
                correct.Content = "Answer Correct!";
                PickQuestion();

            }
            else
            {
                correct.Content = "sorry, try again";

            }
            
        }
    }

}

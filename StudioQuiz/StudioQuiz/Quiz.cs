using System;
using System.Collections.Generic;
using System.Text;

namespace StudioQuiz
{
    class Quiz
    {
        public String Name;
        internal List<Question> Questions = new List<Question>();
        internal Dictionary<string,bool> UserAswers= new Dictionary<string,bool>();
        int Score { get; set; }

        public Quiz(string name)
        {
            this.Name = name;
            this.Score = 0;
        }

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }

        public void Ask(Question question)
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(question.Display());            
            Console.WriteLine("--------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            question.inputAnswer = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            
            if (question.AnswerIsCorrect(question.inputAnswer))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                question.score = 1;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Press any key to continue to the next question.");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect, moving on!");
                question.score = 0;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Press any key to continue to the next question.");
                Console.ReadKey();
            }
        }

        public int CalculateScore()
        {
            int count = 0;
            foreach (Question q in Questions)
            {
                count += q.score;
            }

            return count;
        }


        public void RunQuiz()
        {
            IntroGreeting();
            foreach (Question q in this.Questions)
            {
                Ask(q);
            }
            Console.WriteLine(String.Format("\n\t Your score is {0}/{1}", CalculateScore(), Questions.Count));
        }

        public void IntroGreeting()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Welcome to the Console Quiz!");
            Console.WriteLine(String.Format("You will be presented with {0} questions.", this.Questions.Count));
            Console.WriteLine("Are you ready?");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Press any key to start the quiz...");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
        }


    }


}

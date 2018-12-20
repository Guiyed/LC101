using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudioQuiz
{
    abstract class Question
    {
        private static long id = 0;

        public long Id
        {
            get { return id++; }

        }

        /// <summary>
        /// Create a question object. Pass in a string for a question, an array of strings for possible answers, a question type, and the index integer value for the correct answer in the array.
        
        public int Number;
        public string Text;
        internal readonly int[] CorrectIndex;
        public string inputAnswer;
        public int score;
        //public abstract string TypeOfQuestion { get; set; }
        internal string TypeOfQuestion;

        internal Dictionary<char, int> AnswerDict = new Dictionary<char, int>(){{'a', 0},{'b',1},{'c',2},{'d',3},{'e',4}};
        internal Dictionary<string, string>Questiontypes= new Dictionary<string, string>() {
            { "MC", "Multiple Choice" },
            { "TF", "True and False"},
            { "CB", "Checkbox" }
        };

        internal string[] PossibleAnswer;
        
        public Question(int number, string text, int[] correctIndex )
        {
            this.Number = number;
            this.Text = text;
            this.CorrectIndex = correctIndex;
           

        }

        public Question(int number, string text, int correctIndex)
        {
            this.Number = number;
            this.Text = text;
            CorrectIndex = new int[1];
            CorrectIndex[0] = correctIndex;

        }

        


        public virtual bool AnswerIsCorrect(string answer)
        {                  
            string option = new string(answer.Trim(new Char[] { ' ', '*', '.', ',' }));
            
            if (AnswerDict.TryGetValue(option.ToLower().ToCharArray()[0],out int selection))
            {
                return selection == this.CorrectIndex[0];
            }
            else
            {
            return false;

            }            

        }


        public override string ToString()
        {
            return String.Format("Question {0}: ({1}) ",Number,this.Questiontypes[TypeOfQuestion]);
            
        }

        internal string Display()
        {
            string result = "";
            char option = 'a';
            result += String.Format("Question {0}: ({1})\n  {0}. {2}\n", Number, this.Questiontypes[TypeOfQuestion],Text.ToUpper());
            foreach (string answer in PossibleAnswer)
            {
                result += String.Format("\t{0}) {1}\n", option++, answer);
            }

            return result;

        }

    }



    class MultipleChoice : Question
    {        
        public MultipleChoice(int number, string text, string[] answers, int correctIndex) : base(number, text, correctIndex)
        {
            this.TypeOfQuestion = "MC";
            PossibleAnswer = new string[4];
            for (int i = 0; i < answers.Length; i++)
            {
                this.PossibleAnswer[i] = answers[i];
            }
        }
            
    }

    class TrueFalse : Question
    {
        public TrueFalse(int number, string text, string[] answers, int correctIndex) : base(number, text, correctIndex)
        {
            this.TypeOfQuestion = "TF";
            PossibleAnswer = new string[2];
            for (int i = 0; i < answers.Length; i++)
            {
                this.PossibleAnswer[i] = answers[i];
            }
        }

    }


    class Checkbox : Question
    {
        public Checkbox(int number, string text, string[] answers, int[] correctIndex) : base(number, text, correctIndex)
        {
            this.TypeOfQuestion = "CB";
            PossibleAnswer = new string[4];
            for (int i = 0; i < answers.Length; i++)
            {
                this.PossibleAnswer[i] = answers[i];
            }
        }

        public override bool AnswerIsCorrect(string answer)
        {
            string option = new string(answer.Trim(new Char[] { ' ', '*', '.', ',' }));

            char[] o = option.ToCharArray();
            int[] a = new int[o.Length];

            for (int i = 0; i < o.Length; i++)
            {
                char c = o[i];
                AnswerDict.TryGetValue(c, out int selection);
                a[i] = selection;
            }

            return a.OrderBy(x => x).SequenceEqual(this.CorrectIndex.OrderBy(x => x));
        }

        //TODO
        /*
        class ShortAnswer : Question
        {
        }
        class Paragraph : Question
        {
        }
        class LinearScale : Question
        {
        }
        */




    }


}

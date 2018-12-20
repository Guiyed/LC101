using System;

namespace StudioQuiz
{
    class Program
    {
        static void Main(string[] args)
        {            
            MultipleChoice question1 = new MultipleChoice(1, "How Manny is 1+1?",new string[]{ "3", "2", "4", "7" }, 1);
            MultipleChoice question2 = new MultipleChoice(2, "How Manny is 1+2?", new string[] { "3", "5", "10", "A" }, 0);
            TrueFalse question3 = new TrueFalse(3, "Is this a cool Quiz?", new string[] { "True", "False"}, 0);
            TrueFalse question4 = new TrueFalse(4, "Is the The sky black?", new string[] { "True", "False"}, 1);
            Checkbox question5 = new Checkbox(5, "Which are caracteristics of a cat", new string[] { "It is a felinae", "They bark", "Has a tail", "has 4 legs" }, new int[] {0,2,3 });
            Checkbox question6 = new Checkbox(6, "In Wich years did Emerson Fitipaldi won an F1 Championship title", new string[] { "1970", "1972", "1974", "1975" }, new int[] { 1, 2 }); ;
            /*
             * //Console.WriteLine(question1);
            Console.WriteLine(question1.Display());
            Console.WriteLine(question1.AnswerIsCorrect("a"));
            Console.WriteLine(question1.AnswerIsCorrect("b"));
            Console.WriteLine(question2.Display());

            Console.WriteLine(question3.Display());
            Console.WriteLine(question3.AnswerIsCorrect("a"));
            Console.WriteLine(question4.Display());            
            Console.WriteLine(question5.Display());
            Console.WriteLine(question5.AnswerIsCorrect("acd"));
            Console.WriteLine(question6.Display());
            */
            /*
            Console.WriteLine(question5.AnswerIsCorrect("a,cd"));
            Console.WriteLine(question5.AnswerIsCorrect("a c d"));
            Console.WriteLine(question5.AnswerIsCorrect("ac.d"));
            Console.WriteLine(question5.AnswerIsCorrect("a,c,d"));
            Console.WriteLine(question5.AnswerIsCorrect(" a,c.d"));
            Console.WriteLine(question5.AnswerIsCorrect("acd"));
            */

            Quiz Quiz1 = new Quiz("summer");
            Quiz1.AddQuestion(question1);
            Quiz1.AddQuestion(question2);
            Quiz1.AddQuestion(question3);
            Quiz1.AddQuestion(question4);
            Quiz1.AddQuestion(question5);
            Quiz1.AddQuestion(question6);

            Quiz1.RunQuiz();

            Console.ReadLine();            

        }       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizCon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dictionary<string, string>> qAnswers = new List<Dictionary<string, string>>
            {
                new Dictionary<string, string>(),
                new Dictionary<string, string>()
            };
            //qAnswers[0].Add();


            List<string> Questions = new List<string>
            {
                "What rank did Charlie get demoted to?",
                "What rank is John?",
                "What rifle currently has the longest kill distance?",
                "What day is it on Thursday?",
                "How much RAM does the GTX 970 have?"
            }; //Creates a list of questions

            foreach (string item in Questions) //For each example
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }

            for (int askedQuestion = 0; askedQuestion < Questions.Count(); askedQuestion++) //For example
			{
                Console.WriteLine(Questions[askedQuestion]);
                Console.WriteLine();
			}

            Dictionary<string, string> Answers = new Dictionary<string, string>
            {
                { "Silver 2", "Incorrect" },
                { "Silver Elite", "Correct" },
                { "Global Elite", "Incorrect" },
                { "Silver Master Elite", "Incorrect" }
            }; //Creates a dictionary of answers

            foreach (var pair in Answers)
            {
                Console.WriteLine("{0}, {1}",
                pair.Key,
                pair.Value);
            }

            Console.ReadLine();
        }
    }
}
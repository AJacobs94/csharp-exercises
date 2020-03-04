using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime_
{
    class QuestionOne : Quiz
    {
        public void TrueFalse() {
            string[] questions = new string[] { "First U.S. moon landing happened in 1969", "Gravity is based on the mass of the object", "The sky is green" };
            bool[] answers = new bool[] { true, true, false };
            bool[] responses = new bool[questions.Length];

            int index = 0;
            foreach (string question in questions)
            {
                string input;
                bool isBool;
                bool inputBool;
                Console.WriteLine(question, "true or false?");
                input = Console.ReadLine();
                isBool = Boolean.TryParse(input, out inputBool);
            }
            if (responses == answers)
            {
                index += 1;
            }
        }
        
    }
}

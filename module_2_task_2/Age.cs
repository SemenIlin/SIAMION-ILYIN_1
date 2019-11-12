using System;

namespace module_2_task_2
{
    class Age
    {
        private string _answerString = "";  

        // Output answer on query.
        public string GenerateAnswer(int age)
        {
            _answerString = "";

            if ((age % 2 == 0) && (age > 18))
            {
                _answerString = "Congratulations on your 18th birthday.";
            }
            else if ((age % 2 != 0) && (age < 18) && (age > 13))
            {
                _answerString = "Congratulations on moving to high school.";
            }

            return _answerString;
        }

        public void Show()
        {
            Console.WriteLine(_answerString);
        }
    }
}

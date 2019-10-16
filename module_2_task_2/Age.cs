using System;

namespace module_2_task_2
{
    class Age
    {
        private int _userAge = 0;
        private string _answerString = "";        

        private string OutputErrorMessage(string data)
        {
            char[] tempArray = data.ToCharArray();

            int countPoint = 0;
            int countSign = 0;

            foreach (char ch in tempArray)
            {
                if (Char.IsNumber(ch))
                {
                    continue;
                }

                else if (ch == '.')
                {
                    countPoint++;

                    if (countPoint > 1)
                    {
                        return "Incorrect data.";
                    }
                }

                else if (ch == '-')
                {
                    countSign++;

                    if (countSign > 1)
                    {
                        return "Incorrect data.";
                    }
                }

                else
                {
                    return "Incorrect data.";
                }
            }

            if ((countSign == 1) && (countPoint == 0))
            {
                return "Input data < 0.";
            }

            else if ((countSign == 0) && (countPoint == 1))
            {
                return "Input data include '.' in place ','.";
            }

            else if ((countSign == 1) && (countPoint == 1))
            {
                return "Input data < 0. " + "Input data include '.' in place ','.";
            }

            return "Incorrect data.";
        }

        private void Verify(string data, ref int value)
        {
            while ((!int.TryParse(data, out value)) || (value < 0))
            {
                Console.WriteLine(OutputErrorMessage(data));

                Console.WriteLine("Input value again.");

                data = Console.ReadLine();
            }
        }
        // Input data from user.
        public void Input()
        {
            Console.WriteLine("Input age.");

            Verify(Console.ReadLine(), ref _userAge);
        }

        public int UserAge
        {
            get
            {
                return _userAge;
            }
        }

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

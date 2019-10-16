using System;

namespace module_2_task_2
{
    class Age
    {
        int userAge = 0;
        string answerString = "";        

        string OutputErrorMessage(string data)
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

        void Verify(string data, ref int value)
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

            Verify(Console.ReadLine(), ref userAge);
        }

        public int UserAge { get { return userAge; } }

        // Output answer on query.
        public string GenerateAnswer(int age)
        {
            answerString = "";

            if ((age % 2 == 0) && (age > 18))
            {
                answerString = "Congratulations on your 18th birthday.";
            }

            else if ((age % 2 != 0) && (age < 18) && (age > 13))
            {
                answerString = "Congratulations on moving to high school.";
            }

            return answerString;
        }

        public void Show()
        {
            Console.WriteLine(answerString);
        }
    }
}

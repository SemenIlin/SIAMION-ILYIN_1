using System;

namespace task_5
{
    class Operation
    {
        public void Verify(string data, ref int number)
        {
            while ((!int.TryParse(data, out number)) || (number <= 0))
            {
                Console.WriteLine("Incorrect data, input value again, please.");

                data = Console.ReadLine();
            }
        }

        public void VerifyDigit(string data, ref int digit)
        {
            while ((!int.TryParse(data, out digit)) || (digit <= 0) || (digit > 9) )
            {
                Console.WriteLine("Incorrect data, input value again, please.");

                data = Console.ReadLine();
            }
        }
       
        public int RemoveDigit(int number, int digit)
        {
            string temporaryAnswer = "";

            while (true)
            {
                if ((number % 10) == digit)
                {
                    number /= 10;

                    continue;
                }

                temporaryAnswer = number % 10 + temporaryAnswer;
                if (number / 10 <= 0)
                {
                    break;
                }

                number /= 10;
            }

            return int.Parse(temporaryAnswer); 
        }

        public void Show(int value)
        {
            Console.WriteLine($"result is {value}.");
        }
    }
}

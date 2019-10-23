using System;

namespace ReverseNumber
{
    class ReverseNumber
    {
        public void Verify(string data, ref int value)
        {
            while ((!int.TryParse(data, out value)) || (value <= 0))
            {
                Console.WriteLine("Incorrect data, input value again, please.");

                data = Console.ReadLine();
            }
        }

        public int Reverse(int number)
        {
            string result = "";

            while (true)
            {
                result += number % 10;
                if((number / 10) <= 0)
                {
                    break;
                }

                number /= 10;
            }

            return int.TryParse(result, out number) ? number : 0;
        }

        public void Show(int value)
        {
            Console.WriteLine($"result is {value}.");
        }
    }
}

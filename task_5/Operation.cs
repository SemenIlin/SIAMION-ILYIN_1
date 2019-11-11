namespace task_5
{
    public class Operation
    {
        private readonly string temporaryAnswer = "";

        public Operation(int number, int digit)
        {
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
        }

        public int GetNewNumber()
        {
            return int.Parse(temporaryAnswer);
        }
    }
}

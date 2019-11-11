namespace ReverseNumber
{
    public class ReverseNumber
    {
        private readonly string result = "";

        public ReverseNumber(int number)
        {
            while (true)
            {
                result += number % 10;
                if ((number / 10) <= 0)
                {
                    break;
                }

                number /= 10;
            }
        }

        public int GetReverseNumber()
        {
            return int.TryParse(result, out int number) ? number : 0;
        }
    }
}

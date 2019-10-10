using System;

namespace ChangeValue
{
    class Program
    {
        static void Main(string[] args)
        {
            string value1 = "";
            string value2 = "";

            Operations operation = new Operations();


            operation.Input();

            value1 = operation.Value1FromUser;

            value2 = operation.Value2FromUser;

            operation.Change(ref value1,ref value2);

            operation.Show(value1, value2);

            Console.ReadKey();

        }
    }
}

using System;

namespace ChangeValue
{
    class Operations
    {
        public string Value1FromUser { get; private set; }
        public string Value2FromUser { get; private set; }

        // Input data from user
        public void Input()
        {
            Console.WriteLine("Input first value");
            Value1FromUser = Console.ReadLine();

            Console.WriteLine("Input second value");
            Value2FromUser = Console.ReadLine();
        }
        
        public void Change(ref string val1, ref string val2)
        {
            string tmpvalue = val1;
            val1 = val2;
            val2 = tmpvalue;
        }

        public void Show(string val1, string val2)
        {
            Console.WriteLine($"First value is {val1}, second value is {val2}");
        }
    }
}

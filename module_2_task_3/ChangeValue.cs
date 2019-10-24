using System;

namespace module_2_task_3
{
    class ChangeValue
    { 
        public void Change(ref float value1,ref float value2)
        {
            // Temporary value for data storage.
            float temp = value1;

            value1 = value2;
            value2 = temp;          
        }

        public void Show(float value1, float value2)
        {
            Console.WriteLine($"After change first value is {value1}, second value is {value2}.");
        }

        public void Verify(string data, ref float value)
        {
            while (!float.TryParse(data, out value))
            {
                Console.WriteLine("Invalid data. May be data include later or '.' in place ','. ");
                Console.WriteLine("Input value again");

                data = Console.ReadLine();
            }
        }
    }
}

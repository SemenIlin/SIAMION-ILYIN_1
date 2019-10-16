using System;

namespace module_2_task_3
{
    class ChangeValue
    {
        float value1 = 0F;
        float value2 = 0F;
        string dataFromUser = "";

        // Input date from user.
        public void Input()
        {
            Console.WriteLine("Input first value. ");
            dataFromUser = Console.ReadLine();

            Verify(dataFromUser, ref value1);

            Console.WriteLine("Input second value. ");
            dataFromUser = Console.ReadLine();

            Verify(dataFromUser, ref value2);
        }

        public float Value1 {
            get { return value1; }
            set { value1 = value; }
        }

        public float Value2
        {
            get { return value2; }
            set { value2 = value; }
        }

        public void Change(ref float value1,ref float value2)
        {
            // Temporary value for data storage.
            float temp = value1;

            value1 = value2;
            value2 = temp;

            this.value1 = value1;
            this.value2 = value2;
        }

        public void Show()
        {
            Console.WriteLine($"After change first value is {value1}, second value is {value2}.");
        }

        void Verify(string data, ref float val)
        {

            while (!float.TryParse(data, out val))
            {
                Console.WriteLine("Invalid data. May be data include later or '.' in place ','. ");
                Console.WriteLine("Input value again");

                data = Console.ReadLine();
            }
        }
    }
}

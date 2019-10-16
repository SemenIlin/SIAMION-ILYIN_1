using System;

namespace module_2_task_3
{
    class ChangeValue
    {
        private float _value1 = 0F;
        private float _value2 = 0F;
        private string _dataFromUser;

        // Input date from user.
        public void Input()
        {
            Console.WriteLine("Input first value. ");
          
            _dataFromUser = Console.ReadLine();

            Verify(_dataFromUser, ref _value1);

            Console.WriteLine("Input second value. ");
            _dataFromUser = Console.ReadLine();

            Verify(_dataFromUser, ref _value2);
        }

        public float Value1
        {
            get
            {
                return _value1;
            }
            set
            {
                _value1 = value;
            }
        }

        public float Value2
        {
          get
            {
                return _value2;
            }
            set
            {
                _value2 = value;
            }
        }

        public void Change(ref float value1,ref float value2)
        {
            // Temporary value for data storage.
            float temp = value1;

            value1 = value2;
            value2 = temp;
          
            _value1 = value1;
            _value2 = value2;
          
        }

        public void Show()
        {
            Console.WriteLine($"After change first value is {_value1}, second value is {_value2}.");
        }

        private void Verify(string data, ref float val)
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

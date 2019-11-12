using System;

namespace module_2_task_3
{
    class Change
    { 
        private readonly float value1;
        private readonly float value2;

        public Change(float value1, float value2)
        {
            float temp = value1;

            this.value1 = value2;
            this.value2 = temp;          
        }

        public float GetFirstValue()
        {
            return value1;
        }

        public float GetSecondValue()
        {
            return value2;
        }
    }
}

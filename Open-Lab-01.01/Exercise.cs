using System;

namespace Open_Lab_01._01
{
    public class Exercise
    {
        public bool IsLessThan10(string input)
        {
            int cislo1 = int.Parse(input);
            {
                if (cislo1 < 10)
                    return true;
                else
                    return false;
            }

        }
    }
}

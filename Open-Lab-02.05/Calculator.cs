using System;

namespace Open_Lab_02._05
{
    public class Calculator
    {
        public bool DivisibleByFive(int number)
        {
            int remainder = number % 5;
            if (remainder > 0)
                return false;
            else 
                    return true;
        }
    }
}

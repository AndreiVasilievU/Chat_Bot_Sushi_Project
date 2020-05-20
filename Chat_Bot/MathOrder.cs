using System;
using System.Collections.Generic;
using System.Text;

namespace Chat_Bot
{
    public class MathOrder
    {
        public int NumberDish { get; set; }
        public int CountDish { get; set; }
        public int Sum(int CountDish, int Price)
        {
            int Sum = CountDish * Price;
            return Sum;
        }
    }
}

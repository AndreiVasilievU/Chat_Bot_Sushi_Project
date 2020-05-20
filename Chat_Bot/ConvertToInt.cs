using System;
using System.Collections.Generic;
using System.Text;

namespace Chat_Bot
{
    public class ConvertToInt
    {  
        public int ConvertNumberDish(string order)
        {
            string[] words = order.Split(new char[] { ' ' });
            int NumberDish = Convert.ToInt32(words[0]);
            return NumberDish;
        }
        public int ConvertCountDish(string order)
        {
            string[] words = order.Split(new char[] { ' ' });
            int CountDish = Convert.ToInt32(words[1]);
            return CountDish;
        }
    }
}

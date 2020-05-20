using System;
using System.Collections.Generic;
using System.Text;

namespace Chat_Bot
{
    public class Food
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int CookingTime { get; set; }
        public int Count { get; set; }
        public Food(String name, int price, int cookingTime)
        {
            this.Name = name;
            this.Price = price;
            this.CookingTime = cookingTime;
       }
    }
}

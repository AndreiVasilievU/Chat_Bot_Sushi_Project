using System;
using System.Collections.Generic;
using System.Text;

namespace Chat_Bot
{
    public static class InputHandler
    {
        public static int Sum;
        public static bool isInput = true;
        public static string input;
        public static void Input()
        {
            Console.WriteLine("Введите цифру и кол-во через пробел, если корзина готова нажмите 0");
            while (isInput)
            {
                input = Console.ReadLine();
                if (input.Equals("0"))
                {
                    return;
                }

                MathOrder math = new MathOrder();
                ConvertToInt conv = new ConvertToInt();

                math.NumberDish = conv.ConvertNumberDish(input);
                math.CountDish = conv.ConvertCountDish(input);
                
                if (math.NumberDish > 10)
                {
                    Console.WriteLine("Такого блюда не существует, введите заново");
                    input = Console.ReadLine();

                    math.NumberDish = conv.ConvertNumberDish(input);
                    math.CountDish = conv.ConvertCountDish(input);
                } 

                for(int i = 0; i<Menu.food.Count; i++)
                {
                    if ((i+1).Equals(math.NumberDish))
                    {
                        Menu.AddToFoodOrder(Menu.food[math.NumberDish - 1]);
                        Menu.food[i].Count = math.CountDish;
                        Sum += math.Sum(math.CountDish, Menu.food[math.NumberDish - 1].Price);
                    }
                }
            }  
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Chat_Bot
{
    public class FoodRepository
    {
        //Тут я делал Json

        //public List<Food> sushi = new List<Food>();
        //public List<Food> addSushi()
        //{
            
        //    sushi.Add(new Food("Сяки маки", 280, 10));
        //    sushi.Add(new Food("Филька", 215, 15));
        //    sushi.Add(new Food("Маки сяки", 250, 13));
        //    sushi.Add(new Food("Асикага", 220, 10));
        //    sushi.Add(new Food("Кадзоку", 180, 14));
        //    sushi.Add(new Food("Сакимори", 230, 15));
        //    sushi.Add(new Food("Кайсо", 190, 17));
        //    sushi.Add(new Food("Омура", 270, 20));
        //    sushi.Add(new Food("Сяки Чиз", 255, 25));
        //    sushi.Add(new Food("Сакура", 235, 23));

        //    return sushi;
        //}
        //public void WriteToJason()
        //{
        //    addSushi();
        //    File.WriteAllText("FoodRepository.json", JsonConvert.SerializeObject(sushi));
        //}
        //public void ReadFromJason()
        //{
        //    List<Food> food = new List<Food>();
        //    food = JsonConvert.DeserializeObject<List<Food>>(File.ReadAllText("FoodRepository.json"));
        //    foreach (var item in food)
        //    {
        //        Console.WriteLine(item.Price.ToString());
        //    }
        //}
    }
}

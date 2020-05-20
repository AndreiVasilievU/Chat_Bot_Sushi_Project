using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Chat_Bot
{
    class Program
    {

        static void Main(string[] args)
        {
            Logger.InitLogger();
            Logger.Log.Info("Начало работы программы");
            Person.Introduce();
            Menu.BuildOrder();
            Menu.Order();
            Console.WriteLine(Menu.ShowAllOrder()); 
            Logger.Log.Info("Заказ укомплектован");  
            MailAdressLogic.EnterEmailAdress();
            MailAdressLogic.SendMessage();
            Logger.Log.Info("Информация о заказе ушла на почту");
            Console.WriteLine("Спасибо за заказ!!!!");
        }
    }
}

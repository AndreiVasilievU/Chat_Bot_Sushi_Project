using System;
using System.Collections.Generic;
using System.Text;

namespace Chat_Bot
{
    public static class Person
    {
        public static string Name { get; set; }
        public static string EmailAdress { get; set; }
        public static string Password { get; set; }
        public static void Introduce()
        {
            Console.WriteLine("Здравствуйте, как вас зовут?");
            Name = Console.ReadLine();
            Console.Clear();
        }
    }
}

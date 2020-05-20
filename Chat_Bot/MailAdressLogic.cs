using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Chat_Bot
{
    public static class MailAdressLogic
    { 
        public static void EnterEmailAdress()
        {
            Console.WriteLine("Введите свой email");
            Person.EmailAdress = Console.ReadLine();

            Console.WriteLine("Введите пароль");
            Person.Password = Console.ReadLine();
        }   
        public static void SendMessage() 
        {
            try
            {
                MailAddress from = new MailAddress("puhlikvinni@gmail.com", "ChatBot");
                MailAddress to = new MailAddress(Person.EmailAdress);
                MailMessage m = new MailMessage(from, to);

                m.Subject = "Сообщение о состоянии заказа";
                m.Body =Person.Name + " " + Menu.ShowAllOrder();
                m.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(Person.EmailAdress, Person.Password);
                smtp.EnableSsl = true;
                smtp.Send(m);
            }
            catch
            {
                Logger.InitLogger();
                Logger.Log.Error("Ошибка при указании данных");
                Console.WriteLine("Что-то пошло не так, попробуйте ввести данные заново.");
                EnterEmailAdress();
                SendMessage();
            }
        }
    }
}

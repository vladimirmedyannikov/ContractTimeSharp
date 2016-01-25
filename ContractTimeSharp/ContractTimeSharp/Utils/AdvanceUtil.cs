using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace ContractTimeSharp.Utils
{
    static class AdvanceUtil
    {
        public enum paramStagInsert { SUB, NOSUB };
        public enum typeUser { ADMIN = 1, USER = 0};
        public enum stageStatus {FACT = 1, PLAN = 0, ALL = 3 };

        private static String smtpHost = "smtp.mail.ru";
        //Порт SMTP-сервера
        private static int smtpPort = 25;
        //Логин
        private static String smtpUserName = "mr.betchit@mail.ru";
        //Пароль
        private static String smtpUserPass = "MAngysT<>Shadum123";

        private static String msgFrom = "mr.betchit@mail.ru";

        public static void  SendMessage(string email, string messageMail)
        {
            //Создание подключения
            SmtpClient client = new SmtpClient(smtpHost, smtpPort);
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(smtpUserName, smtpUserPass);
            client.EnableSsl = true;

            //Адрес для поля "От"
            
            //Адрес для поля "Кому" (адрес получателя)
            String msgTo = email;

            //Тема письма
            String msgSubject = "Theme mail";
            //Текст письма, можно использовать html
            String msgBody = messageMail;
            //Вложение для письма
            //Если нужно больше вложений, для каждого вложения создаем свой объект Attachment с нужным путем к файлу
            //Attachment attachData = new Attachment(@"D:\Тестовое вложение.zip");

            //Создание сообщения
            MailMessage message = new MailMessage(msgFrom, msgTo, msgSubject, msgBody);

            //Указываем что текст сообщения содержит html контент
            message.IsBodyHtml = true;
            //Крепим к сообщению подготовленное заранее вложение
            //message.Attachments.Add(attachData);

            try
            {
                //Отсылаем сообщение
                client.Send(message);
            }
            catch (SmtpException ex)
            {
                //В случае ошибки при отсылке сообщения можем увидеть, в чем проблема
                MessageBox.Show(ex.Message);

            }
        }
    }
}

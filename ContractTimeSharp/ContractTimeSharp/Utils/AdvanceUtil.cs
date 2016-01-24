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

        public static void  SendMessage(string email, string messageMail)
        {
            String smtpHost = "smtp.mail.ru";
            //Порт SMTP-сервера
            int smtpPort = 25;
            //Логин
            String smtpUserName = "yourmail@bk.ru";
            //Пароль
            String smtpUserPass = "YourPassWord";

            //Создание подключения
            SmtpClient client = new SmtpClient(smtpHost, smtpPort);
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(smtpUserName, smtpUserPass);
            client.EnableSsl = true;

            //Адрес для поля "От"
            String msgFrom = "yourmail@bk.ru";
            //Адрес для поля "Кому" (адрес получателя)
            String msgTo = "tomail@tobe.com, lolka@mail.ru";

            //Тема письма
            String msgSubject = "Theme mail";
            //Текст письма, можно использовать html
            String msgBody = "Тут текст письма <table><tr><td>1</td><td>2</td></tr></table>";
            //Вложение для письма
            //Если нужно больше вложений, для каждого вложения создаем свой объект Attachment с нужным путем к файлу
            Attachment attachData = new Attachment(@"D:\Тестовое вложение.zip");

            //Создание сообщения
            MailMessage message = new MailMessage(msgFrom, msgTo, msgSubject, msgBody);

            //Указываем что текст сообщения содержит html контент
            message.IsBodyHtml = true;
            //Крепим к сообщению подготовленное заранее вложение
            message.Attachments.Add(attachData);

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

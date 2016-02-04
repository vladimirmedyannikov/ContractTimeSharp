using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ContractTimeSharp.Utils
{
    public static class AdvanceUtil
    {
        public enum paramStagInsert { SUB, NOSUB };
        public enum typeUser { ADMIN = 1, USER = 0};
        public enum stageStatus {FACT = 1, PLAN = 0, ALL = 3 };

        private static String smtpHost = Properties.Settings.Default.smtpHost;
        //Порт SMTP-сервера
        private static int smtpPort = Properties.Settings.Default.smtpPort;
        //Логин
        private static String smtpUserName = Properties.Settings.Default.smtpUserName;
        //Пароль
        private static String smtpUserPass = Properties.Settings.Default.smtpUserPass;

        private static String msgFrom = Properties.Settings.Default.msgFrom;

        public static bool IsValidEmail(string strIn)
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        public static void  SendMessage(string email, string messageMail)
        {

            if (IsValidEmail(email))
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
                String msgSubject = "Заполнение информации в системе «Букля»";
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
                    client.SendAsync(message, message);
                }
                catch (SmtpException ex)
                {
                    //В случае ошибки при отсылке сообщения можем увидеть, в чем проблема
                    MessageBox.Show(ex.Message);

                }
            }
            else
                return;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Mail;

//using EASendMailRT;
//using System.Threading.Tasks;


namespace tech_hub_recreate
{
    class Class1
    {

        public void email_send()
        {
            //Адрес SMTP-сервера
            String smtpHost = "SMTP.gmail.com";
            //Порт SMTP-сервера
            int smtpPort = 587;
            //Логин
            String smtpUserName = "abdo14hashem15@gmail.com";
            //Пароль
            String smtpUserPass = "ihtpspri";

            //Создание подключения
            SmtpClient client = new SmtpClient(smtpHost, smtpPort);
            //client.EnableSsl = true;
//            client.ConnectType = SmtpConnectType.ConnectSSLAuto;
            client.Credentials = new NetworkCredential(smtpUserName, smtpUserPass);

            //Адрес для поля "От"
            String msgFrom = smtpUserName;
            //Адрес для поля "Кому" (адрес получателя)
            String msgTo = "ar1813@fayoum.edu.eg";
            //Тема письма
            String msgSubject = "Письмо от C#";
            //Текст письма
            String msgBody = "Привет!\r\n\r\nЭто тестовое письмо\r\n\r\n--\r\nС уважением, C# :-)";

            //Создание сообщения
            MailMessage message = new MailMessage(msgFrom, msgTo, msgSubject, msgBody);

            
                //Отсылаем сообщение
                client.Send(message);
            
            //catch (SmtpException ex)
            //{
            //    Window1 next_win = new Window1();
          //      next_win.Show();
              //  next_win.task_content_val = (ex.InnerException.Message.ToString());

                //В случае ошибки при отсылке сообщения можем увидеть, в чем проблема
        //    }
        }


    }





}

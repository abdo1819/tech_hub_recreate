using System;
using System.Collections.Generic;
using System.Windows;

// Add EASendMail namespace
using EASendMail;


namespace tech_hub_recreate
{
    class Class1
    {

        public bool email_send(string name, string field,int num)
        {
//add server data
            String smtpHost = "smtp.mail.ru";
            int smtpPort = 465;
            String smtpUserName = "abdo.hashem98@mail.ru";
            String smtpUserPass = "fkKGjQw6EGRMmfz";
 //add messege data
            String msgFrom = smtpUserName;
            String msgTo = "ar1813@fayoum.edu.eg";
            String msgSubject = name ;
            String msgBody = $"{field} task number {num}";
 
            SmtpMail message = new SmtpMail("TryIt");
            message.From = msgFrom;
            message.To = msgTo;
            message.Subject = msgSubject;
            message.TextBody = msgBody;

 //connect to server
            SmtpServer oServer = new SmtpServer(smtpHost);
            oServer.User = msgFrom;
            oServer.Password = smtpUserPass;
            oServer.Port = smtpPort;
            oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;

            SmtpClient oSmtp = new SmtpClient();
            try
            {
                oSmtp.SendMail(oServer, message);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private int pcb = 0, embedded = 1, programing = 2;

        //tasks move to data class
        IList<string> embedded_tasks = new List<string>() { "task_emb1", "task_emb2", "task_emb3", "task_emb4" };
        IList<string> programming_tasks = new List<string>() { "task_prog1", "task_prog2", "task_prog3" };
        IList<string> pcb_tasks = new List<string>() { "task_pcb1"};

        public void open_task(int task,string name)
        {
            Window1 next_win = new Window1();
            next_win.Show();
            next_win.task_content_val = "loading...";


            Random rnd = new Random();
            int max_embedded = 4, max_programming = 3, max_pcb = 1;
            int rnd_num;

         

            Class1 fun = new Class1();
            if (task == pcb)
            {
                rnd_num = rnd.Next(0, max_pcb);
                if (fun.email_send(name, "pcb", rnd_num))
                {
                    next_win.task_content_val = pcb_tasks[rnd_num];
                }
                else
                {
                    MessageBox.Show("check internet connection if your netowrk work contact me");
                }
            }
            else if (task == embedded)
            {

                rnd_num = rnd.Next(0, max_embedded);
                if (fun.email_send(name, "embedded", rnd_num))
                {
                    next_win.task_content_val = embedded_tasks[rnd_num];
                }
                else
                {
                    MessageBox.Show("check internet connection if your netowrk work contact me");
                }

            }
            else if (task == programing)
            {

                rnd_num = rnd.Next(0, max_programming);
                if (fun.email_send(name, "programming", rnd_num))
                {
                    next_win.task_content_val = programming_tasks[rnd_num];
                }
                else
                {
                    MessageBox.Show("check internet connection if your netowrk work contact me");
                }

            }



            
        }


    }





}

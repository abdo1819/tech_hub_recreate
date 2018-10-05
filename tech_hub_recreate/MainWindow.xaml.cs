using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace tech_hub_recreate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private int pcb=0, embedded=1, programing=2;

        //tasks move to data class
        IList<string> embedded_tasks = new List<string>() { "task_emb1", "task_emb2", "task_emb3", "task_emb4" };
        IList<string> programming_tasks = new List<string>() { "task_prog1", "task_prog2", "task_prog3" };
               
        private void open_task(int task)
        {
            Window1 next_win = new Window1();
            next_win.Show();
            

            Random rnd = new Random();
            int max_embedded = 4,max_programming = 3;
            int rnd_num;


            Class1 fun = new Class1();
            if (task == pcb)
            {
                next_win.task_content_val = "pcb";
            }
            else if (task == embedded){
                rnd_num = rnd.Next(1, max_embedded);
                next_win.task_content_val = embedded_tasks[rnd_num];
                fun.email_send();
            }
            else if (task == programing)
            {
                rnd_num = rnd.Next(1, max_programming);
                next_win.task_content_val = programming_tasks[rnd_num];
            }



            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = username.Text;



            // int num = Random


            if (pcb_box.IsChecked == true)
            {
                open_task(pcb);
            }
            else if(programming_box.IsChecked == true)
            {
                //open random embedded task
                open_task(programing);
            }
            else if(embedded_box.IsChecked == true){
                //open random embedded task
                open_task(embedded);

            }
            else
            {
                MessageBox.Show("please select a track");
            }
            
        }

        private void delete_text(object sender, MouseButtonEventArgs e)
        {
            username.Clear();

        }
        
    }
}

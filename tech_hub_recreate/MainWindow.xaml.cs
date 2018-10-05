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

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Class1 fun = new Class1();
            string name = username.Text;


            if (name == "write your name  here !" || name.Count(Char.IsWhiteSpace) < 2)
            {
                MessageBox.Show("please write your complate name");
            }
            else
            {
                if (pcb_box.IsChecked == true)
                {
                    fun.open_task(pcb, name);
                    this.Close();
                }
                else if (programming_box.IsChecked == true)
                {
                    //open random embedded task
                    fun.open_task(programing, name);
                    this.Close();
                }
                else if (embedded_box.IsChecked == true)
                {
                    //open random embedded task
                    fun.open_task(embedded, name);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("please select a track");
                }
            }
        }

        private void delete_text(object sender, MouseButtonEventArgs e)
        {
            username.Clear();

        }
        
    }
}

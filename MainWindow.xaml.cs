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

namespace WPF_UI
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

        public void createTask()
        {
            if (userInput.Text != "")
            {
                addTask();
            }
        }

        public void addTask()
        {

            StackPanel fullTask = new StackPanel();
            fullTask.Orientation = Orientation.Horizontal;
            taskContainer.Children.Add(fullTask);


            TextBlock task = new TextBlock();
            task.Text = userInput.Text;
            task.FontFamily = userInput.FontFamily;
            task.FontSize = 18;
            task.FontWeight = userInput.FontWeight;
            task.Foreground = new SolidColorBrush(Colors.White);
            Grid.SetColumn(task, 3);
            Grid.SetRow(task, 3);

            fullTask.Children.Add(task);



            Button removeBtn = new Button();
            removeBtn.Foreground = new SolidColorBrush(Colors.Red);
            removeBtn.Content = "r";
            removeBtn.Width = 30;
            removeBtn.Height = 30;
            Grid.SetColumn(removeBtn, 5);
            Grid.SetRow(removeBtn, 3);


            fullTask.Children.Add(removeBtn);

        }

        private void add_task_Click(object sender, RoutedEventArgs e)
        {
            createTask();
            userInput.Text = "";
        }

    }
    
}

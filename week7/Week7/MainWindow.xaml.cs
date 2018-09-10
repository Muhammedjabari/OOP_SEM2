using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Week7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> Tasks { get; set; }
        public  MainWindow()
        {
            InitializeComponent();
            Tasks = new ObservableCollection<string>();
            this.Namelist.ItemsSource = Tasks;
        }



        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Tasks.Add(tasknames.Text);
            tasknames.Clear();

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            while (Namelist.SelectedItems.Count > 0) {
                Tasks.Remove(Namelist.SelectedItems[0] as string);
                tasknames.Clear();
            }
       
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            int Index = Namelist.SelectedIndex;
            Tasks.RemoveAt(Index);
            Tasks.Insert(Index, tasknames.Text);
            tasknames.Clear();

        }

        private void Namelist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                tasknames.Text = Namelist.SelectedItems[0].ToString();
            }
            catch {
            }
        }
    }
}

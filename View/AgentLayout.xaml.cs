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
using System.Windows.Shapes;
using DemoAppZhdan.Model;

namespace DemoAppZhdan.View
{
    /// <summary>
    /// Логика взаимодействия для AgentLayout.xaml
    /// </summary>
    public partial class AgentLayout : Window
    {
        AgentDBEntities context = new AgentDBEntities();
        List<string> sortList = new List<string>();
        List<string> filterList = new List<string>();
        public AgentLayout()
        {
            InitializeComponent();
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            filterList.Add("Фильтрация");
            foreach (var agentType in context.AgentType.ToList())
            {
                filterList.Add(agentType.Title);
            }
            CBFilter.SelectedIndex = 0;
            CBFilter.ItemsSource = filterList;

            sortList.Add("Сортировка");
            sortList.Add("По возрастанию");
            sortList.Add("По убыванию");
            CBSort.SelectedIndex = 0;
            CBSort.ItemsSource = sortList;

        }
    }
}

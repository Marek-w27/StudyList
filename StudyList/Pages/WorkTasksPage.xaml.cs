using StudyList.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudyList
{
    /// <summary>
    /// Interaction logic for WorkTasksPage.xaml
    /// </summary>
    public partial class WorkTasksPage : UserControl
    {
        public WorkTasksPage()
        {
            InitializeComponent();

            DataContext = new WorkTasksPageVievModel();
        }

        private void OpentAIWTP(object sender, RoutedEventArgs e)
        {
            AddItemWTP addItemWTP = new AddItemWTP();
            addItemWTP.ShowDialog();
        }
    }
}

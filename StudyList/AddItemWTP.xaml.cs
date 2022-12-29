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
using System.Windows.Shapes;
using StudyList.Core;

namespace StudyList
{
    /// <summary>
    /// Logika interakcji dla klasy AddItemWTP.xaml
    /// </summary>
    public partial class AddItemWTP : Window
    {
        public WorkTasksPageVievModel WorkTasksPageVievModel { get; private set; }

        public AddItemWTP()
        {
            InitializeComponent();
        }

        private void Zamknij(object sender, RoutedEventArgs e)
        {
            
            
            this.Close();
        }

        private void AnulujZamknij(object sender, RoutedEventArgs e)
        {

            this.Close();
        }

        private void BottonAdd(object sender, RoutedEventArgs e)
        {
            WorkTasksPageVievModel = new WorkTasksPageVievModel();
            WorkTasksPageVievModel.AddNewTask();
            this.Close();

        }
    }
}

using StudyList.Core.Helpers;
using StudyList.Database;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace StudyList
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);


            var dataBase = new StudyListDbContext();

            dataBase.Database.EnsureCreated();
            DataBaseLocator.Database = dataBase;
        }
    }
}

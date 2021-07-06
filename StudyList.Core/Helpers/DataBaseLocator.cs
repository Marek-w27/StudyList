using StudyList.Database;
using System;
using System.Collections.Generic;
using System.Text;


namespace StudyList.Core.Helpers
{
    public class DataBaseLocator
    {
      

        public static StudyListDbContext Database { get ; set; }
    }
}

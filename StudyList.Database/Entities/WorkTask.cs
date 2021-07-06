using System;
using System.Collections.Generic;
using System.Text;

namespace StudyList.Database
{
     public class WorkTask

    {
        public int Id { set; get; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }

    }
}

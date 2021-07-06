using System;
using System.Collections.Generic;
using System.Text;

 namespace StudyList.Core
{
    public class WorkTaskVievModel : BaseVievModel
    {
        public int Id { set; get; }
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool IsSelected { get; set; }
    }
}

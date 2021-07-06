using System;
using System.Collections.Generic;
using System.Text;

namespace StudyList.NotificationModel
{
    public class NotificationMessage
    {
        private string _message = "";
        private string _title = "";

        public string Message { get => _message; set => _message = value; }
        public string Title { get => _title; set => _title = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace StudyList.NotificationModel
{
    public class CloseNotificationMessage : NotificationMessage
    {
        public CloseNotificationMessage()
        {
            Title = "Close";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioApplicationPlayerAbstract
{
    public interface INotification
    {
        void NotificationClassification(NotificationType type);
    }
}

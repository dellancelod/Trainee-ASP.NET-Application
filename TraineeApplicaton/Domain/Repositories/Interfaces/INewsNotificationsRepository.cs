using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraineeApplication.Domain.Entities;

namespace TraineeApplication.Domain.Repositories.Interfaces
{
    interface INewsNotificationsRepository
    {
        IQueryable<NewsNotification> GetNewsNotificationItems();
        void SaveNewsNotificationItem(NewsNotification entity);
        void DeleteNewsNotificationItem(Guid id);
    }
}

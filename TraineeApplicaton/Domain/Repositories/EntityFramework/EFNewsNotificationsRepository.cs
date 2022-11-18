using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraineeApplication.Domain.Entities;
using TraineeApplication.Domain.Repositories.Interfaces;

namespace TraineeApplication.Domain.Repositories.EntityFramework
{
    public class EFNewsNotificationsRepository : INewsNotificationsRepository
    {
        private readonly AppDbContext context;
        public EFNewsNotificationsRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void DeleteNewsNotificationItem(Guid id)
        {
            context.NewsNotifications.Remove(new NewsNotification{ Id = id });
            context.SaveChanges();
        }

        public IQueryable<NewsNotification> GetNewsNotificationItems()
        {
            return context.NewsNotifications;
        }

        public void SaveNewsNotificationItem(NewsNotification entity)
        {
            if (entity.Id == default)
            {
                context.Entry(entity).State = EntityState.Added;
            }
            else
            {
                context.Entry(entity).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
        
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraineeApplication.Domain.Entities;
using TraineeApplication.Domain.Repositories.Interfaces;

namespace TraineeApplication.Domain.Repositories.EntityFramework
{
    public class EFMessageItemsRepository : IMessageItemsRepository
    {
        private readonly AppDbContext context;
        public EFMessageItemsRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void DeleteMessageItem(Guid id)
        {
            context.MessageItems.Remove(new MessageItem { Id = id });
            context.SaveChanges();
        }

        public MessageItem GetMessageItemById(Guid id)
        {
            return context.MessageItems.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<MessageItem> GetMessageItems()
        {
            return context.MessageItems;
        }

        public void SaveMessageItem(MessageItem entity)
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

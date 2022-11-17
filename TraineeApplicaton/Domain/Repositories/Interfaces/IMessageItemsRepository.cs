using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraineeApplication.Domain.Entities;

namespace TraineeApplication.Domain.Repositories.Interfaces
{
    public interface IMessageItemsRepository
    {
        IQueryable<MessageItem> GetMessageItems();
        MessageItem GetMessageItemById(Guid id);
        void SaveMessageItem(MessageItem entity);
        void DeleteMessageItem(Guid id);
    }
}

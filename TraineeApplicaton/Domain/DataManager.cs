 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraineeApplication.Domain.Repositories.Interfaces;

namespace TraineeApplication.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }
        public INewsItemsRepository NewsItems { get; set; }
        public IMessageItemsRepository MessageItems { get; set; }
        public INewsNotificationsRepository NewsNotifications { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, IServiceItemsRepository entitysRepository, 
            INewsItemsRepository newsItemRepository, IMessageItemsRepository messageItemsRepository,
            INewsNotificationsRepository newsNotificationsRepository)
        {
            TextFields = textFieldsRepository;
            ServiceItems = entitysRepository;
            NewsItems = newsItemRepository;
            MessageItems = messageItemsRepository;
            NewsNotifications = newsNotificationsRepository;
        }
    }
}

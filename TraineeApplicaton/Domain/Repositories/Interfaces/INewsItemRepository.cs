using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraineeApplication.Domain.Entities;

namespace TraineeApplication.Domain.Repositories.Interfaces
{
    interface INewsItemRepository
    {
        IQueryable<NewsItem> GetNewsItems();
        NewsItem GetNewsItemById(Guid id);
        void SaveNewsItem(NewsItem entity);
        void DeleteNewsItem(Guid id);
    }
}

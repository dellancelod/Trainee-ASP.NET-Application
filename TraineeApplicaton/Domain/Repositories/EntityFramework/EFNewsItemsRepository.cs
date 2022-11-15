using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraineeApplication.Domain.Entities;
using TraineeApplication.Domain.Repositories.Interfaces;

namespace TraineeApplication.Domain.Repositories.EntityFramework
{
    public class EFNewsItemsRepository : INewsItemsRepository
    {
        private readonly AppDbContext context;
        public EFNewsItemsRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void DeleteNewsItem(Guid id)
        {
            context.NewsItems.Remove(new NewsItem { Id = id });
            context.SaveChanges();
        }

        public NewsItem GetNewsItemById(Guid id)
        {
            return context.NewsItems.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<NewsItem> GetNewsItems()
        {
            return context.NewsItems;
        }

        public void SaveNewsItem(NewsItem entity)
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

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraineeApplication.Domain;
using TraineeApplication.Domain.Entities;

namespace TraineeApplication.Model.ViewComponents
{
    public class ChatViewComponent : ViewComponent
    {
        
        public Task<IViewComponentResult> InvokeAsync()
        {
            MessageItem entity = default;
            return Task.FromResult((IViewComponentResult)View("Default", entity));
        }
    }
}

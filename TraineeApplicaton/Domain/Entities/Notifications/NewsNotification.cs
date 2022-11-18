using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraineeApplication.Domain.Entities
{
    public class NewsNotification : NotificationBase
    {
        [Required]
        public bool Approved { get; set; }
    }
}

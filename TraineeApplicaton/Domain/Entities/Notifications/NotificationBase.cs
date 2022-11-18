using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraineeApplication.Domain.Entities
{
    public abstract class NotificationBase
    {

        protected NotificationBase() => DateAdded = DateTime.UtcNow;
        [Required]
        public Guid Id { get; set; }
        public string SenderID { get; set; }
        public string ReceiverID { get; set; }
        [Display(Name = "Назва (заголовок)")]
        public virtual string Title { get; set; }
        [Display(Name = "Короткий опис")]
        public virtual string Text { get; set; }
        [Display(Name = "Титульне зображення")]
        public DateTime DateAdded { get; set; }

    }
}

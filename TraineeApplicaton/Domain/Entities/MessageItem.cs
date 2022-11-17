using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraineeApplication.Domain.Entities
{
    public class MessageItem : EntityBase
    {
        [Required]
        [Display(Name = "Ім'я відправника")]
        public string SenderName { get; set; }
        [Display(Name = "Текст повідомлення")]
        public override string Text { get; set; }
    }
}

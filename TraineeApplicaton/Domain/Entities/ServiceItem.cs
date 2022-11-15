using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraineeApplication.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage ="Заповніть назву послуги")]
        [Display(Name = "Назва послуги")]
        public override string Title { get; set; } = "Інформаційна сторінка";
        [Display(Name = "Опис послуги")]
        public override string Subtitle { get; set; } = "Інформаційна сторінка";
        [Display(Name = "Вміст сторінки")]
        public override string Text { get; set; } = "Вміст заповнюється адміністратором";

    }
}

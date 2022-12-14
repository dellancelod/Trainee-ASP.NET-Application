using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraineeApplication.Domain.Entities
{
    public class NewsItem : EntityBase
    {
        [Required(ErrorMessage = "Заповніть заголовок новини")]
        [Remote(action: "IsTitleAvailable", controller:"NewsItems", ErrorMessage = "Заголовок вже існує")]
        [Display(Name = "Заголовок")]
        public override string Title { get; set; } = "Заголовок";
        [Display(Name = "Текст новини")]
        public override string Text { get; set; } = "Вміст заповнюється адміністратором";
        public string AuthorID { get; set; } = "410fd6fc-c0eb-4671-b6b9-f245d78a8516";
        public bool Hidden { get; set; }
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema; //для изменения схемы БД

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; } //Поле ID является обязательным для первичного ключа базы данных.

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Дата выхода")]
        [DataType(DataType.Date)] //Атрибут DataType указывает тип данных (Date). Отображается только дата, не требуется вводить сведения о времени в поле даты
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")] //изменение схемы колонки в БД
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string Rating { get; set; }
    }
}

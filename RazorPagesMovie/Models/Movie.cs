using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; } //Поле ID является обязательным для первичного ключа базы данных.
        public string Title { get; set; }

        [DataType(DataType.Date)] //Атрибут DataType указывает тип данных (Date). Отображается только дата, не требуется вводить сведения о времени в поле даты
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}

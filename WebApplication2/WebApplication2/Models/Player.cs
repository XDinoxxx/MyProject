using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Player
    {

        public int Id { get; set; }

        [Display(Name = "Введите имя")]
        [Required(ErrorMessage = "Вам нужно ввести имя")]
        public string Name { get; set; }

        [Display(Name = "Введите фамилию")]
        [Required(ErrorMessage = "Вам нужно ввести фамилию")]
        public string Surname { get; set; }

        [Display(Name = "Введите пол")]
        [Required(ErrorMessage = "Вам нужно ввести пол")]
        public string Gender { get; set; }

        [Display(Name = "День")]
        [Required(ErrorMessage = "Вам нужно ввести день")]
        public ushort Day { get; set; }

        [Display(Name = "Месяц")]
        [Required(ErrorMessage = "Вам нужно ввести месяц")]
        public ushort Month { get; set; }

        [Display(Name = "Год")]
        [Required(ErrorMessage = "Вам нужно ввести год")]
        public ushort Year { get; set; }

        [Display(Name = "Введите название команды")]
        [Required(ErrorMessage = "Вам нужно ввести название команды")]
        public string Teamname { get; set; }

        [Display(Name = "Выберите страну")]
        [Required(ErrorMessage = "Вам нужно выбрать страну")]
        public string Country { get; set; }

    }
}

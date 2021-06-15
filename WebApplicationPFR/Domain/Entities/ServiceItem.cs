using System.ComponentModel.DataAnnotations;

namespace WebApplicationPFR.Domain.Entities
{
    public class ServiceItem : Employes
    {
        [Required(ErrorMessage = "Заполните поля")]
        [Display(Name = "FIO")]
        public override string FIO { get; set; }

        [Display(Name = "Отдел/кабинет")]
        public override string otdel { get; set; }

        [Display(Name = "Кабинет")]
        public override int Room { get; set; }

        [Display(Name = "Монитор")]
        public override string mon { get; set; }

        [Display(Name = "Компьютер")]
        public override string pc { get; set; }

        [Display(Name = "Принтер")]
        public override string printer { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationPFR.Domain.Entities
{
    public class Employes
    {
        [Required]
        public  Guid Id { get; set; }

        [Display(Name = "ФИО")]
        public virtual string FIO { get; set; }

        [Display(Name = "Отдел/кабинет")]
        public virtual string otdel { get; set; }

        [Display(Name = "Кабинет")]
        public virtual int Room { get; set; }

        [Display(Name = "Монитор")]
        public virtual string mon { get; set; }

        [Display(Name = "Компьютер")]
        public virtual string pc { get; set; }

        [Display(Name = "Принтер")]
        public virtual string printer { get; set; }


        public int? PC_ID { get; set; }
        public PC PC { get; set; }
        public int? Mon_ID { get; set; }
        public Monitors Monitors { get; set; }
        public int? Printer_ID { get; set; }
        public Printers Printers { get; set; }
    }
}

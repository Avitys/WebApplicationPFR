using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationPFR.Domain.Entities
{
    public class Printers
    {
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Принтер")]
        public virtual string printer { get; set; }

        [Display(Name = "Принтер-серийный")]
        public virtual string printer_ser { get; set; }

        [Display(Name = "Принтер-инвентарный")]
        public virtual string printer_inv { get; set; }
    }
}

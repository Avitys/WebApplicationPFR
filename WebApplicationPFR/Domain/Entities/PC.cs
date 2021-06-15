using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationPFR.Domain.Entities
{
    public class PC
    {
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Компьютер")]
        public virtual string pc { get; set; }

        [Display(Name = "Компьютер-серийнйы")]
        public virtual string pc_ser { get; set; }

        [Display(Name = "Компьютер-инвентарный")]
        public virtual string pc_inv { get; set; }
    }
}

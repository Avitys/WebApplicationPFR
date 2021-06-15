using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationPFR.Domain.Entities
{
    public class Monitors
    {
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Монитор")]
        public virtual string mon { get; set; }

        [Display(Name = "Монитор-серийнйы")]
        public virtual string mon_ser { get; set; }

        [Display(Name = "Монитор-инвентарный")]
        public virtual string mon_inv { get; set; }
    }
}

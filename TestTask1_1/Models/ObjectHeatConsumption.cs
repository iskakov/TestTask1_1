using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestTask1_1.Models
{
    public class ObjectHeatConsumption
    {
        public Guid PrimaryKey { get; set; }
        [Display(Name = "Наименование объекта")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Дата регистрации объекта")]
        [Required]
        public DateTime? DateRegistration { get; set; }
        [Display(Name = "Персональный счет потребителя")]
        [Required]

        public Consumer Consumer { get; set; }
    }
}
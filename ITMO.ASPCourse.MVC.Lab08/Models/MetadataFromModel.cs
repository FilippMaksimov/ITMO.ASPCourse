using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITMO.ASPCourse.MVC.Lab08.Models
{
    public class CreditMetadata
    {
        [Required]
        public string Head { get; set; }
        [Required]
        public int Period { get; set; }
        [Required]
        public int Sum { get; set; }
        [Required]
        public int Procent { get; set; }
    }
    public class BidMetadata
    {
        [DisplayName("Имя заявителя")]
        [Required]
        public string Name { get; set; }
        [DisplayName("Название кредита")]
        [Required]
        public string CreditHead { get; set; }
        [DisplayName("Дата подачи заявки")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        public System.DateTime bidDate { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RejestracjaNaPraktykiWBillennium.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Registration
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Imi� i Nazwisko jest wymagane ")]
        [MaxLength(50, ErrorMessage = "Przekroczono maksymaln� ilo�� znak�w")]
        [DisplayName("Imi� i Nazwisko")]
        public string NameAndSurname { get; set; }
        [DataType(DataType.MultilineText)]
        [DisplayName("Dlaczego chcia�by� uczestniczy� w praktykach")]
        public string Opinion { get; set; }
    }
}

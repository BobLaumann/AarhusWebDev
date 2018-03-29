using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AarhusWebDevCoop.ViewModels
{
    public class ContactForm
    {
        [Required(ErrorMessage = "Please enter your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your E-mail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter the Subject")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Please write a Message")]
        public string Message { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;

namespace ContactDemo.Domain
{
    public class Contact
    {
        //contacts(which have names, phone numbers, emails etc)
        public int ID { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date), Display(Name = "Date of Birth")]
        public DateTime BirthDay { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber), Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        
    }
}

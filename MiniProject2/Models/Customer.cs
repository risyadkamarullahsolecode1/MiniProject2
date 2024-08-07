﻿using System.ComponentModel.DataAnnotations;

namespace MiniProject2.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        [StringLength(100), MinLength(2)]
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [StringLength(200)]
        public string Address { get; set; }
        public DateTime RegistrationDate {  get; set; }
    }
}

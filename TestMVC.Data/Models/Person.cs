using System;
using System.ComponentModel.DataAnnotations;
using TestMVC.Data.Enumerations;

namespace TestMVC.Data.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Sex Sex { get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }
    }
}
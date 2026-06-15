using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Car.Models
{
    public class Car
    {
        [Key]
        public int MpsId { get; set; }
        public string? Model { get; set; }
        public double PowerKW { get; set; }
        public string? EcoCategory { get; set; }
        public double Tax { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
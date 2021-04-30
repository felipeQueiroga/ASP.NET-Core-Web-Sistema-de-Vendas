using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
       
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
       
        [DisplayName("Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }
       
        [DisplayName("Base SAlary")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        public double BaseSAlary { get; set; }
      
        public Department Department { get; set; }
       
        [DisplayName("Departments")]
        public int DepartmentId { get; set; }
       
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSAlary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSAlary = baseSAlary;
            Department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime inictial, DateTime final)
        {
            return Sales.Where(w => w.Date >= inictial && w.Date <= final).Sum(w => w.Amount);
        }
    }
}

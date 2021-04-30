using SalesWebMvc.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
       
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
       
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Amount { get; set; }
       
        public SaleStatus Stataus { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus stataus, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Stataus = stataus;
            Seller = seller;
        }
    }
}

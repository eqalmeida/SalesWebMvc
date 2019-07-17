using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amont { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }
        public SalesRecord(int id, DateTime date, double amont, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amont = amont;
            Status = status;
            Seller = seller;
        }
    }
}

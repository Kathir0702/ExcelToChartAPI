using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExcelToChartAPI.Models
{
    public class ExcelData
    {
        public int id { get; set; }
        public string name { get; set; }
        public decimal amount { get; set; }
        public int year { get; set; }   
    }
}
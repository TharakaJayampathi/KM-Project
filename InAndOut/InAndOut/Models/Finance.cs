using InAndOut.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Models
{
    public class Finance
    {
        [Key]
        public int Id { get; set; }
        public string ExpenseName { get; set; }
        public string ExpenseType { get; set; }
        public string Amount { get; set; }
    }
}

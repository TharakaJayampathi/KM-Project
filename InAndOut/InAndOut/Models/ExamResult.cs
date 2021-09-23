using InAndOut.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Models
{
    public class ExamResult
    {
        [Key]
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string ExamName { get; set; }
        public string ExamType { get; set; }
        public string Duration { get; set; }
        public string Marks { get; set; }
    }
}

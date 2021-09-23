using InAndOut.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Models
{
    public class FileUpload
    {
        [Key]
        public int Imgid { get; set; }

        public string Imgname { get; set; }

        public string Imgpath { get; set; }
    }
}

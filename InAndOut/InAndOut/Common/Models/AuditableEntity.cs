using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Common.Models
{
    public class AuditableEntity
    {
        public string CreatedUserId { get; set; }
        public string CreatedUser { get; set; }

        public string ModifiedUserId { get; set; }
        public string ModifiedUser { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

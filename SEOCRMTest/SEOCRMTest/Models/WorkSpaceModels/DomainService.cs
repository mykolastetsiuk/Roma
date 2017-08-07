using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEOCRMTest.Models.WorkSpaceModels
{
    public class DomainService
    {
        public int DomainId { get; set; }
        public virtual Domain Domain { get; set; }
        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }
    }
}

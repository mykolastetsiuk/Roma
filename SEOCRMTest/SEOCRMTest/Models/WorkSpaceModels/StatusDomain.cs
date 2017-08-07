using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEOCRMTest.Models.WorkSpaceModels
{
    public class StatusDomain
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Domain> Domains { get; set; }
    }
}

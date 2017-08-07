using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SEOCRMTest.Models.WorkSpaceModels
{
    public class DomainAdminPanel : AdminPanel
    {
        public int DomainId { get; set; }
        [ForeignKey("Id")]
        public virtual Domain Domain { get; set; }
    }
}

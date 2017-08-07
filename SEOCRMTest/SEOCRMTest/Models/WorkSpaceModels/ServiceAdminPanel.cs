using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SEOCRMTest.Models.WorkSpaceModels
{
    public class ServiceAdminPanel : AdminPanel
    {
        public int ServiceId { get; set; }
        [ForeignKey("Id")]
        public virtual Service Service { get; set; }
    }
}

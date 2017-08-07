using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SEOCRMTest.Models.WorkSpaceModels
{
    public class ServiceSupportPanel : SupportPanel
    {
        public int ServiceId { get; set; }
        [ForeignKey("Id")]
        public virtual Service Service { get; set; }
    }
}

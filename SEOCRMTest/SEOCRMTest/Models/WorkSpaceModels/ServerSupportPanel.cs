using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SEOCRMTest.Models.WorkSpaceModels
{
    public class ServerSupportPanel : SupportPanel
    {
        public int ServerId { get; set; }
        [ForeignKey("Id")]
        public virtual Server Server { get; set; }
    }
}

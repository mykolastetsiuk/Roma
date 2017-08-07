using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SEOCRMTest.Models.WorkSpaceModels
{
    public class RegistrarSupportPanel : SupportPanel
    {
        public int RegistrarId { get; set; }
        [ForeignKey("Id")]
        public virtual Registrar Registrar { get; set; }
    }
}

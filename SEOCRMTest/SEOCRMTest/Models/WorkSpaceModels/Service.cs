using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SEOCRMTest.Models.WorkSpaceModels
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset ExpiredDate { get; set; }
        public int ServiceAdminPanelId { get; set; }
        public int? ServiceSupportPanelId { get; set; }
        public string AdditionalInfo { get; set; }

        public virtual ICollection<DomainService> DomainService { get; set; }
        [ForeignKey("Id")]
        public virtual ServiceAdminPanel ServiceAdminPanel { get; set; }
        [ForeignKey("Id")]
        public virtual ServiceSupportPanel ServiceSupportPanel { get; set; }
    }
}

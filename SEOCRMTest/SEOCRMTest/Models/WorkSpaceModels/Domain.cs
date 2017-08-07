using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SEOCRMTest.Models.WorkSpaceModels
{
    public class Domain
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MainDomain { get; set; }
        public string IP { get; set; } 
        public DateTimeOffset ExpiredDate { get; set; }
        public int ServerId { get; set; }
        public int RegistrarId { get; set; }
        public int ProjectId { get; set; }
        public int OwnerId { get; set; }
        public int TypeDomainId { get; set; }//TODO ICollection<TypeDomain>???
        public string Redirect { get; set; } //TODO if TypeDomainId is Redirect set Redirect srting
        public int StatusDomainId { get; set; }//TODO ICollection<StatusDomain>???
        
        public int? DomainAdminPanelId { get; set; }
        public string AdditionalInfo { get; set; }

        public virtual Server Server { get; set; }
        public virtual Registrar Registrar { get; set; }
        public virtual Project Project { get; set; }
        public virtual Owner Owner { get; set; }
        public virtual TypeDomain TypeDomain { get; set; }
        public virtual StatusDomain StatusDomain { get; set; }
        [ForeignKey("Id")]
        public virtual DomainAdminPanel DomainAdminPanel { get; set; }

        public virtual ICollection<DomainService> DomainService { get; set; }

        //TODO add SEO info
    }
}

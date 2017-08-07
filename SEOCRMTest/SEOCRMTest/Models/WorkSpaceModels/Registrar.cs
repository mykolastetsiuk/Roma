using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SEOCRMTest.Models.WorkSpaceModels
{
    public class Registrar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegistrarAdminPanelId { get; set; }
        public int? RegistrarSupportPanelId { get; set; }
        public string AdditionalInfo { get; set; }

        public virtual ICollection<Domain> Domains { get; set; }
        [ForeignKey("Id")]
        public virtual RegistrarAdminPanel RegistrarAdminPanel { get; set; }
        [ForeignKey("Id")]
        public virtual RegistrarSupportPanel RegistrarSupportPanel { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SEOCRMTest.Models.WorkSpaceModels
{
    public class Server
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset ExpiredDate { get; set; }
        public int ServerAdminPanelId { get; set; }
        public int? ServerSupportPanelId { get; set; }
        public string AdditionalInfo { get; set; }

        [ForeignKey("Id")]
        public virtual ServerAdminPanel ServerAdminPanel { get; set; }
        [ForeignKey("Id")]
        public virtual ServerSupportPanel ServerSupportPanel { get; set; }
        public virtual ICollection<Domain> Domains { get; set; }
    }
}

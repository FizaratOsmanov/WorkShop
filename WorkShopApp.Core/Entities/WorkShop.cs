using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopApp.Core.Entities.Base;

namespace WorkShopApp.Core.Entities
{
    public class WorkShop:BaseAuditableEntity
    {
        public string Title { get; set; }

        public string? Description { get; set; }

        public DateTime? Date {  get; set; }

        public string? Location { get; set; }

        public ICollection<Participant>? Participants { get; set; }
    }
}

using WorkShopApp.Core.Entities.Base;

namespace WorkShopApp.Core.Entities
{
    public  class Participant:BaseAuditableEntity
    {

        public string Name { get; set; }

        public string? Email {  get; set; }

        public string? Phone { get; set; }

        public int? WorkShopId { get; set; }

        public WorkShop? WorkShop { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
using FoodTruck.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodTruck.Data.Helpers
{
    public static class UpdateAuditableItems
    {
        public static void SetCreated(this IAuditable auditable, IUserSession userSession)
        {
            auditable.CreatedBy = userSession.Id;
            auditable.CreatedDate = DateTime.Now;
        }

        public static void SetUpdated(this IAuditable auditable, IUserSession userSession)
        {
            auditable.ModifiedBy = userSession.Id;
            auditable.ModifiedDate = DateTime.Now;
        }
    }
}

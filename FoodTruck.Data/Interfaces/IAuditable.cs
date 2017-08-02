using System;
using System.Collections.Generic;
using System.Text;

namespace FoodTruck.Data.Interfaces
{
    public interface IAuditable
    {
        Guid CreatedBy { get; set; }
        DateTime CreatedDate { get; set; }
        Guid ModifiedBy { get; set; }
        DateTime ModifiedDate { get; set; }
    }
}

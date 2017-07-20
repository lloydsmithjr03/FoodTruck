using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FoodTruck.Data.Queries.Interfaces
{
    public interface IQuery<T>
    {
        T Execute(IDbConnection db);
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FoodTruck.Data.Queries.Interfaces
{
    public interface IQuery<TResult>
    {
    }

    public interface IQueryHandler<in TQuery, out TResult>
        where TQuery : IQuery<TResult>
    {
        TResult Execute(TQuery query);
    }
}

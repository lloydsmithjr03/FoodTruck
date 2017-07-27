using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace FoodTruck.Data.Commands.Interfaces
{
    public interface ICommand
    {
    }

    public interface ICommandHandler<T> : ICommand
    {
        void Execute(T command);
    }
}

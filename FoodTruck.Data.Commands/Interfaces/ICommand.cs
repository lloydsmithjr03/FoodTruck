using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace FoodTruck.Data.Commands.Interfaces
{
    public interface ICommand
    {
        void Execute();
    }
}

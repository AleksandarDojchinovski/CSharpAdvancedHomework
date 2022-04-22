using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IRepairService
    {
        public void CheckVehicle(Vehicle vehicle);
        public void FixVehicle(Vehicle vehicle);
    }
}

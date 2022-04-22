using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CarCenter
    {
        public CarWash CarWash { get; set; }
        public GasPump GasPump { get; set; }
        public RepairService RepairService { get; set; }

        public CarCenter()
        {
            CarWash = new CarWash();
            GasPump = new GasPump();    
            RepairService = new RepairService();
        }
    }
}

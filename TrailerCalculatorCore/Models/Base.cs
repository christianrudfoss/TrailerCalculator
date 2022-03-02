using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrailerCalculatorCore.Models
{
    public class Base
    {
        public string RegistrationNumber { get; set; }
        public int TotalWeight { get; set; }
        public int DeadWeight { get; set; }
        public int LoadWeight { get; set; }
        public int MaxTotalWeight { get; set; }

        //public int TotalWeightCalculate ()
        //{
        //    return DeadWeight + LoadWeight;
        //}
    }
}

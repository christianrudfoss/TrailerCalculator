using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    internal class Licence
    {
        public string SertificateClassName { get; set; }
        public double MaxTrailerWeight { get; set; }
        public double MaxTotalWeight { get; set; }
    }
}

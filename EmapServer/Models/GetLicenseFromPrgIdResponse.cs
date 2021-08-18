using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMAPContext;

namespace EmapServer.Models
{
    public class GetLicenseFromPrgIdResponse
    {
        public string LicenseResponse { get; set; }
        public LICENSER Licenses { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMAPContext;
using EmapModel;
using EmapServer.Models;

namespace EmapServer.Controllers
{
    public class LicenseController : Controller
    {
        public IActionResult GetLicenseFromPrgId(string programid)
        {
            var resp = new GetLicenseFromPrgIdResponse();
            var emapContext = new EMAPDataContext(DatabaseGlobalization.GetConnection().ConnectionString);
            resp.Licenses = emapContext.LICENSERs.SingleOrDefault(x => x.PRGID == programid);
            resp.LicenseResponse = resp.Licenses == null ? "NOTFOUND" : "FOUND";
            return Ok(resp);
        }
    }
}

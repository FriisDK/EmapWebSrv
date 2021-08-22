using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMAPContext;
using EmapModel;
using EmapServer.Models;
using Microsoft.Extensions.Logging;

namespace EmapServer.Controllers
{
    [Route("License")]
    public class LicenseController : Controller
    {

        private ILogger Logger { get; }
        public LicenseController(ILogger<LicenseController> logger)
        {
            Logger = logger;
        }

        [HttpGet("GetLicenseFromPrgId")]
        public IActionResult GetLicenseFromPrgId(string programid)
        {
            try
            {
                Logger.LogInformation($"GetLicenseFromPrgId called with id: {programid}");
                var resp = new GetLicenseFromPrgIdResponse();
                var emapContext = new EMAPDataContext(DatabaseGlobalization.GetConnection().ConnectionString);
                resp.Licenses = emapContext.LICENSERs.SingleOrDefault(x => x.PRGID == programid);
                resp.LicenseResponse = resp.Licenses == null ? "NOTFOUND" : "FOUND";
                return Ok(resp);
            }
            catch (Exception e)
            {
                Logger.LogError("GetLicenseFromPrgId", e);
                throw;
            }
        }

        
        [HttpGet("AddComputerFromId")]
        public IActionResult AddComputerFromId(string programid, string computerId)
        {
            try
            {
                Logger.LogInformation($"AddComputerFromId called with id: {programid} {computerId}");
                var resp = new GetLicenseFromPrgIdResponse();
                var emapContext = new EMAPDataContext(DatabaseGlobalization.GetConnection().ConnectionString);
                resp.Licenses = emapContext.LICENSERs.SingleOrDefault(x => x.PRGID == programid);
                resp.LicenseResponse = resp.Licenses == null ? "NOTFOUND" : "FOUND";

                if (resp.Licenses != null)
                {
                    if (string.IsNullOrEmpty(resp.Licenses.CPUID1))
                        resp.Licenses.CPUID1 = computerId;
                    else if (string.IsNullOrEmpty(resp.Licenses.CPUID2))
                        resp.Licenses.CPUID2 = computerId;
                    else if (string.IsNullOrEmpty(resp.Licenses.CPUID3))
                        resp.Licenses.CPUID3 = computerId;


                    Logger.LogInformation($"Set license: {programid} {computerId}");

                    emapContext.SubmitChanges();
                }

                

                return Ok(resp);
            }
            catch (Exception e)
            {
                Logger.LogError("AddComputerFromId", e);
                throw;
            }
        }
        
    }
}

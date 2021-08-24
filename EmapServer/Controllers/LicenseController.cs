using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
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
        public IActionResult GetLicenseFromPrgId()
        {
            var programId = Request.Query["programid"].FirstOrDefault();
            var computerId = Request.Query["computerid"].FirstOrDefault();
            var resp = new GetLicenseFromPrgIdResponse();

            try
            {
                Logger.LogInformation($"GetLicenseFromPrgId called with id: {programId} computer {computerId}");

                if (!string.IsNullOrEmpty(programId) && !string.IsNullOrEmpty(computerId))
                {
                    var emapContext = new EMAPDataContext(DatabaseGlobalization.GetConnection().ConnectionString);
                    var licens = emapContext.LICENSERs.SingleOrDefault(x => x.PRGID == programId);
                    resp = new GetLicenseFromPrgIdResponse(licens, computerId);
                }
                
                return Ok(resp);
            }
            catch (Exception e)
            {
                Logger.LogError("GetLicenseFromPrgId", e);
                throw;
            }
        }
      
        [HttpPost("AddComputerFromId")]
        public IActionResult AddComputerFromId()
        {
            var programId = Request.Query["programid"].FirstOrDefault();
            var computerId = Request.Query["computerid"].FirstOrDefault();
            var resp = new GetLicenseFromPrgIdResponse();
            try
            {
                Logger.LogInformation($"AddComputerFromId called with id: {programId} {computerId}");
               

                if (!string.IsNullOrEmpty(programId) && !string.IsNullOrEmpty(computerId))
                {
                    var emapContext = new EMAPDataContext(DatabaseGlobalization.GetConnection().ConnectionString);
                    var license = emapContext.LICENSERs.SingleOrDefault(x => x.PRGID == programId);

                    if (license != null)
                    {
                        if (string.IsNullOrEmpty(license.CPUID1))
                            license.CPUID1 = computerId;
                        else if (string.IsNullOrEmpty(license.CPUID2))
                            license.CPUID2 = computerId;
                        else if (string.IsNullOrEmpty(license.CPUID3))
                            license.CPUID3 = computerId;

                        Logger.LogInformation($"Set license: {programId} {computerId}");

                        emapContext.SubmitChanges();
                    }

                    resp = new GetLicenseFromPrgIdResponse(license, computerId);
                }
                return Ok(resp);
            }
            catch (Exception e)
            {
                Logger.LogError("AddComputerFromId", e);
                throw;
            }
        }

        [HttpPost("UpdateCustomer")]
        public IActionResult UpdateCustomer()   
        {
            var programId = Request.Query["programid"].FirstOrDefault();

            try
            {
                Logger.LogInformation($"UpdateCustormer called with id: {programId}");
                if (!string.IsNullOrEmpty(programId))
                {
                    var custerRequst = this.GetRequestBody<UpdateCustomerRequest>();
                    var emapContext = new EMAPDataContext(DatabaseGlobalization.GetConnection().ConnectionString);
                    var license = emapContext.LICENSERs.SingleOrDefault(x => x.PRGID == programId);
                    GetLicenseFromPrgIdResponse.UpdateCustomerRequest(ref license, custerRequst);
                    emapContext.SubmitChanges();
                }

                return Ok();
            }
            catch (Exception e)
            {
                Logger.LogError("UpdateCustormer", e);
                throw;
            }
        }
    }
}

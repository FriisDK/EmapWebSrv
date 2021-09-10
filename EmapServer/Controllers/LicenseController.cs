using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
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

            try
            {
                Logger.LogInformation($"GetLicenseFromPrgId called with id: {programId} computer {computerId}");
                
                GetLicenseFromPrgIdResponse resp;
                if (!string.IsNullOrEmpty(programId) )
                {
                    var emapContext = new EMAPDataContext(DatabaseGlobalization.GetConnection().ConnectionString);
                    var licens = emapContext.LICENSERs.SingleOrDefault(x => x.PRGID == programId);
                    resp = new GetLicenseFromPrgIdResponse(licens, computerId);
                } else
                {
                    resp = new();
                    resp.LicenseResponse = LicenseResponse.LicenseNotFound;
                }

                return Ok(resp);
            }
            catch (Exception e)
            {
                Logger.LogError("GetLicenseFromPrgId", e);
                throw;
            }
        }

        [HttpGet("AddComputerFromId")]
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

        [HttpGet("RemoveComputerFromId")]
        public IActionResult RemoveComputerFromId()
        {
            var programId = Request.Query["programid"].FirstOrDefault();
            var computerId = Request.Query["computerid"].FirstOrDefault();
            var resp = new GetLicenseFromPrgIdResponse();
            try
            {

                if (!string.IsNullOrEmpty(programId) && !string.IsNullOrEmpty(computerId))
                {
                    var emapContext = new EMAPDataContext(DatabaseGlobalization.GetConnection().ConnectionString);
                    var license = emapContext.LICENSERs.SingleOrDefault(x => x.PRGID == programId);

                    if (license != null)
                    {
                        if (license.CPUID1 == computerId)
                            license.CPUID1 = null;
                        if (license.CPUID2 == computerId)
                            license.CPUID2 = null;
                        if (license.CPUID3 == computerId)
                            license.CPUID3 = null;

                        emapContext.SubmitChanges();
                    }
                }
                
                return Ok(resp);
            }
            catch (Exception e)
            {
                Logger.LogError("AddComputerFromId", e);
                throw;
            }
        }
        
        [HttpGet("UpdateCustomer")]
        public IActionResult UpdateCustomer()
        {
            var programId = Request.Query["programid"].FirstOrDefault();
            var customerName = Request.Query["customername"].FirstOrDefault();
            var customerAddress = Request.Query["customeraddress"].FirstOrDefault();
            var customerAddress1 = Request.Query["customeraddress1"].FirstOrDefault();
            var customerZipcode = Request.Query["customerzipcode"].FirstOrDefault();
            var customerCity = Request.Query["customercity"].FirstOrDefault();
            var customerCountry = Request.Query["customercountry"].FirstOrDefault();
            var customerEmailaddress = Request.Query["Customeremailaddress"].FirstOrDefault();

            var resp = new GetLicenseFromPrgIdResponse();
            try
            {
                Logger.LogInformation($"UpdateCustomer called with id: {programId}");
                if (!string.IsNullOrEmpty(programId))
                {
                    var emapContext = new EMAPDataContext(DatabaseGlobalization.GetConnection().ConnectionString);
                    var license = emapContext.LICENSERs.SingleOrDefault(x => x.PRGID == programId);

                    if (license != null)
                    {
                        license.CUSTNAME = customerName;
                        license.CUSTADD = customerAddress;
                        license.CUSTADD1 = customerAddress1;
                        license.CUSTZIP = customerZipcode;
                        license.CUSTCITY = customerCity;
                        license.CUSTCOUNTRY = customerCountry;
                        license.CUSTEMAIL = customerEmailaddress;

                        emapContext.SubmitChanges();
                    }

                    resp = new GetLicenseFromPrgIdResponse(license, programId);

                }

                return Ok(resp);

            }

            catch (Exception e)
            {
                Logger.LogError("UpdateCustormer", e);
                throw;
            }
        }
    }
}

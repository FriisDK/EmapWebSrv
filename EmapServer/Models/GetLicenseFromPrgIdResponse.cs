using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMAPContext;
using Microsoft.AspNetCore.Connections.Features;

namespace EmapServer.Models
{

    public enum LicenseResponse
    {
        LicenseFound,
        LicenseNotFound
    }

    public enum ComputerIdStatus
    {
        Current,
        IsUse,
        Free
    }
    public class GetLicenseFromPrgIdResponse
    {
        public LicenseResponse LicenseResponse { get; set; }
        public ComputerIdStatus ComputerId1State { get; set; }
        public ComputerIdStatus ComputerId2State { get; set; }
        public ComputerIdStatus ComputerId3State { get; set; }

        public string ComputerId1 { get; set; }
        public string ComputerId2 { get; set; }
        public string ComputerId3 { get; set; }
        
        public string CustomerName  { get; set; }
        public string CustomerAddress  { get; set; }
        public string CustomerAddress1  { get; set; }
        public string CustomerZipcode  { get; set; }
        public string CustomerCity  { get; set; }
        public string CustomerCountry  { get; set; }
        public string CustomerEmailAddress  { get; set; }

        public GetLicenseFromPrgIdResponse()
        {
        }

        public UpdateCustomerRequest GetUpdateCustomerRequest()
        {
            return new UpdateCustomerRequest
            {
                CustomerName = CustomerName,
                CustomerAddress = CustomerAddress,
                CustomerAddress1 = CustomerAddress1,
                CustomerZipcode = CustomerZipcode,
                CustomerCity = CustomerCity,
                CustomerCountry = CustomerCountry,
                CustomerEmailAddress = CustomerEmailAddress
            };
        }

        public static void UpdateCustomerRequest(ref LICENSER license, UpdateCustomerRequest updRequst)
        {
            license.CUSTNAME = updRequst.CustomerName;
            license.CUSTADD = updRequst.CustomerAddress;
            license.CUSTADD1 = updRequst.CustomerAddress1;
            license.CUSTZIP = updRequst.CustomerZipcode;
            license.CUSTCITY = updRequst.CustomerCity;
            license.CUSTCOUNTRY = updRequst.CustomerCountry;
            license.CUSTEMAIL = updRequst.CustomerEmailAddress;
        }

        public GetLicenseFromPrgIdResponse(LICENSER licens, string callingComputerId)
        {
            if (licens == null)
            {
                LicenseResponse = LicenseResponse.LicenseNotFound;
            }
            else
            {
                LicenseResponse = LicenseResponse.LicenseFound;
                if (string.IsNullOrEmpty(licens.CPUID1))
                {
                    ComputerId1State = ComputerIdStatus.Free;
                }
                else
                {
                    ComputerId1State = licens.CPUID1 == callingComputerId
                        ? ComputerIdStatus.Current
                        : ComputerIdStatus.IsUse;
                }

                if (string.IsNullOrEmpty(licens.CPUID2))
                {
                    ComputerId2State = ComputerIdStatus.Free;
                }
                else
                {
                    ComputerId2State = licens.CPUID2 == callingComputerId
                        ? ComputerIdStatus.Current
                        : ComputerIdStatus.IsUse;
                }

                if (string.IsNullOrEmpty(licens.CPUID3))
                {
                    ComputerId3State = ComputerIdStatus.Free;
                }
                else
                {
                    ComputerId3State = licens.CPUID3 == callingComputerId
                        ? ComputerIdStatus.Current
                        : ComputerIdStatus.IsUse;
                }

                CustomerName = licens.CUSTNAME;
                CustomerAddress = licens.CUSTADD;
                CustomerAddress1 = licens.CUSTADD1;
                CustomerZipcode = licens.CUSTZIP;
                CustomerCity = licens.CUSTCITY;
                CustomerCountry = licens.CUSTCOUNTRY;
                CustomerEmailAddress = licens.CUSTEMAIL;

                ComputerId1 = licens.CPUID1;
                ComputerId2 = licens.CPUID2;
                ComputerId3 = licens.CPUID3;


            }
        }
    }
}

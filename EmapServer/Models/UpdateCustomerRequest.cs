using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmapServer.Models
{
    public class UpdateCustomerRequest
    {
        public string CustomerName  { get; set; }
        public string CustomerAddress  { get; set; }
        public string CustomerAddress1  { get; set; }
        public string CustomerZipcode  { get; set; }
        public string CustomerCity  { get; set; }
        public string CustomerCountry  { get; set; }
        public string CustomerEmailAddress  { get; set; }
    }
}

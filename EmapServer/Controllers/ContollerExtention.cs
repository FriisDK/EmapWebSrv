using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using EmapServer.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmapServer.Controllers
{
    public static class ContollerExtention
    {
        public static T GetRequestBody<T>(this Controller controller)
        {
            using var reader = new StreamReader(controller.Request.Body, Encoding.UTF8, true, 1024, false);
            var bodyStr = reader.ReadToEnd();
            return JsonSerializer.Deserialize<T>(bodyStr);
        }
    }
}

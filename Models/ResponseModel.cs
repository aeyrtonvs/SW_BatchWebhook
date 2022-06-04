using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SW_APIS.Models
{
    public class ResponseModel
    {
        public string status { get; set; } = "success";
        public string message { get; set; } = String.Empty;
    }
}

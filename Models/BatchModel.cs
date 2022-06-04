using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SW_APIS.Models
{
    public class BatchModel
    {
        public string UrlOutput { get; set; }
        public string UrlReport { get; set; }
        public string UrlReportError { get; set; }
    }
}

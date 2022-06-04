using MimeKit;
using SW_APIS.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace SW_APIS.Services
{
    public class BatchService
    {
        public static async Task<ResponseModel> SaveReport(BatchModel batch)
        {
            var status = "success";
            try
            {
                var dir = String.Format("{0}\\Resources\\report\\reports.txt", Directory.GetCurrentDirectory());
                var content = String.Format("{0}\nOutput     -----> {1}\nReport     -----> {2}\nError      -----> {3}\n\n", DateTime.Now.ToString(), batch.UrlOutput, batch.UrlReport, batch.UrlReportError);
                File.WriteAllText(dir, content);
            }
            catch(Exception e)
            {
                status = "error";
            }

            return new ResponseModel()
            {
                status = status,
                message = String.Empty
            };
        }
        public static ResponseModel ValidateRequest(BatchModel batchRequest)
        {
            if(batchRequest is null || (batchRequest.UrlOutput is null || batchRequest.UrlReport is null || batchRequest.UrlReportError is null))
            {
                return new ResponseModel()
                {
                    status = "error",
                    message = "El request viene vacío."
                };
            }
            return new ResponseModel();
        }
    }
}

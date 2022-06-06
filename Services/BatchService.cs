using MimeKit;
using SW_APIS.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SW_APIS.Services
{
    public class BatchService
    {
        public static async Task<ResponseModel> SaveReportAsync(BatchModel batch, ClaimsPrincipal user)
        {
            var status = "success";
            var message = String.Empty;
            string separator = "---------------------";
            string name = String.Empty;
            try
            {
                var dir = String.Format("{0}\\Resources\\report\\reportsLog.txt", Environment.CurrentDirectory);
                var content = String.Format("{0}\n[{1}]\nUser   -----> {2}\nOutput -----> {3}\nReport -----> {4}\nError  -----> {5}\n{6}\n\n",
                                            separator, DateTime.Now.AddHours(-5).ToString("dd/MM/yyyyTHH-mm-ss"), TryGetUser(user, out name) ? name : "Unknown", 
                                            batch.UrlOutput, batch.UrlReport, batch.UrlReportError, separator);
                await File.AppendAllTextAsync(dir, content);
            }
            catch(Exception e)
            {
                status = "error";
                message = e.Message;
            }

            return new ResponseModel()
            {
                status = status,
                message = message
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
        private static bool TryGetUser(ClaimsPrincipal user, out string name)
        {
            name = user.Identity.Name;
            if (String.IsNullOrEmpty(name))
            {
                return false;
            }
            return true;
        }
    }
}

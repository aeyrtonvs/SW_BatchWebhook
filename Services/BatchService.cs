using MimeKit;
using SW_APIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace SW_APIS.Services
{
    public class BatchService
    {
        public static async void SendMail(List<string> emailTo, string subject)
        {
            //try
            //{
            //    var mensaje = new MimeMessage();
            //    mensaje.From.Add(new MailboxAddress("Batch Service", ""));
            //    mensaje.To.Add(new MailboxAddress("", to));
            //    mensaje.Subject = subject;

            //    var bodyBuilder = new BodyBuilder();
            //    bodyBuilder.HtmlBody = content;
            //    bodyBuilder.Attachments.Add(file);
            //    mensaje.Body = bodyBuilder.ToMessageBody();

            //    using (var client = new SmtpClient("myHost", myPort))
            //    {
            //        client.Send(mensaje);
            //    }

            //    estado = true;
            //    return estado;
            //}
            //catch (Exception ex)
            //{
            //    return estado;
            //}
        }
        public static ResponseModel ValidateRequest(BatchModel batchRequest)
        {
            if(batchRequest is null)
            {
                return new ResponseModel()
                {
                    status = "error",
                    message = "El request viene vacío."
                };
            }
            return new ResponseModel()
            {
                status = "success"
            };
        }
    }
}

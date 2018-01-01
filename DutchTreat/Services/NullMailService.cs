using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace DutchTreat.Services
{
    public class NullMailService : IMailService
    {
        private readonly ILogger<NullMailService> logger;

        public NullMailService(ILogger<NullMailService> logger)
        { // in video it's _logger=logger;
            this.logger = logger;
        }

        public void SendMessage(string to, string subject, string body)
        {
            // Log the message
            // in video it's _logger.etc
            this.logger.LogInformation($"To: {to} Subject: {subject} Body: {body}");
        }
    }
}

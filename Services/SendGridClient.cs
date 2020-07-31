using System;
using System.Threading.Tasks;

namespace VintageStuff.Web.Services
{
    internal class SendGridClient
    {
        private string apiKey;

        public SendGridClient(string apiKey)
        {
            this.apiKey = apiKey;
        }

        internal Task SendEmailAsync(SendGridMessage msg)
        {
            throw new NotImplementedException();
        }
    }
}
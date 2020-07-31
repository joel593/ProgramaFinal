using System;

namespace VintageStuff.Web.Services
{
    internal class SendGridMessage
    {
        public SendGridMessage()
        {
        }

        public object From { get; set; }
        public string Subject { get; set; }
        public string PlainTextContent { get; set; }
        public string HtmlContent { get; set; }

        internal void AddTo(EmailAddress emailAddress)
        {
            throw new NotImplementedException();
        }

        internal void SetClickTracking(bool v1, bool v2)
        {
            throw new NotImplementedException();
        }
    }
}
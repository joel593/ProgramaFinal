namespace VintageStuff.Web.Services
{
    internal class EmailAddress
    {
        private string v;
        private string sendGridUser;
        private string email;

        public EmailAddress(string email)
        {
            this.email = email;
        }

        public EmailAddress(string v, string sendGridUser)
        {
            this.v = v;
            this.sendGridUser = sendGridUser;
        }
    }
}
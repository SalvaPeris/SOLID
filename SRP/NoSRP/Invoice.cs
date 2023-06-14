using System.Net.Mail;

namespace NoSRP
{
    public class Invoice
    {
        public long InvoiceAmount { get; set; }
        public DateTime InvoiceDate { get; set; }
        
        public void AddInvoice()
        {
            try
            {
                MailMessage mailMessage = new MailMessage("EMailFrom", "EMailTo", "EMailSubject", "EMailBody");
                this.SendInvoiceEmail(mailMessage);
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }

        public void DeleteInvoice()
        {
            try
            {
                //Here we need to write the Code for Deleting the already generated invoice
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }

        public void SendInvoiceEmail(MailMessage mailMessage)
        {
            try
            {
                // Here we need to write the Code for Email setting and sending the invoice mail
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }
    }
}

namespace CustomerCommunicationLibrary
{
    /// <summary>
    /// The class under test (CUT).
    ///
    /// DEPENDENCY INJECTION (Constructor Injection):
    /// Instead of creating an IEmailService internally, CustomerNotification
    /// RECEIVES it from outside via the constructor. This means:
    ///   • In production  → pass a real EmailService
    ///   • In unit tests  → pass a Mock<IEmailService> (no SMTP needed)
    ///
    /// This pattern is called "Inversion of Control" (IoC) and is the
    /// foundation of loosely-coupled, testable code.
    /// </summary>
    public class CustomerNotification
    {
        private readonly IEmailService _emailService;

        // Constructor Injection — the dependency is injected here.
        public CustomerNotification(IEmailService emailService)
        {
            _emailService = emailService;
        }

        /// <summary>
        /// Sends a notification email to a customer.
        /// The actual SMTP work is delegated to _emailService — in tests
        /// this will be a mock object, so no real email is ever sent.
        /// </summary>
        public bool SendMailToCustomer()
        {
            // Real business logic would build the address and message.
            string customerEmail = "cust123@abc.com";
            string messageBody = "Some Message";

            return _emailService.SendMail(customerEmail, messageBody);
        }
    }
}

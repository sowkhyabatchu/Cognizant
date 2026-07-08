namespace CustomerCommunicationLibrary
{
    /// <summary>
    /// Interface for sending emails.
    /// By programming to an interface rather than a concrete class,
    /// we can swap in a real EmailService in production and a mock
    /// service in unit tests — this is the key to testable design.
    /// </summary>
    public interface IEmailService
    {
        bool SendMail(string toAddress, string message);
    }
}

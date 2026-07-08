using Moq;
using NUnit.Framework;
using CustomerCommunicationLibrary;

namespace CustomerCommunication.Tests
{
    /// <summary>
    /// NUnit test class for CustomerNotification.
    ///
    /// KEY CONCEPTS:
    ///  • Mock<T>        — creates a fake object that implements T
    ///  • Setup()        — configures what the mock should return
    ///  • It.IsAny<T>()  — wildcard matcher: accept any value of type T
    ///  • Verify()       — asserts the mock method was actually called
    ///
    /// [TestFixture] — marks this class as an NUnit test container
    /// </summary>
    [TestFixture]
    public class CustomerNotificationTests
    {
        // The mock replaces the real EmailService so no SMTP server is needed.
        private Mock<IEmailService> _mockEmailService;

        // The object we are actually testing.
        private CustomerNotification _customerNotification;

        /// <summary>
        /// [OneTimeSetUp] runs ONCE before ALL tests in the class.
        /// </summary>
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            TestContext.WriteLine("=== CustomerNotificationTests fixture starting ===");
        }

        /// <summary>
        /// [SetUp] runs before EACH test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            // 1. Create the mock object for IEmailService.
            _mockEmailService = new Mock<IEmailService>();

            // 2. Configure the mock.
            _mockEmailService
                .Setup(m => m.SendMail(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(true);

            // 3. Inject the mock via constructor injection.
            _customerNotification = new CustomerNotification(_mockEmailService.Object);
        }

        /// <summary>
        /// [TearDown] runs after EACH test.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            _mockEmailService = null;
            _customerNotification = null;
        }

        // ─── Test Cases ───────────────────────────────────────────────────────

        /// <summary>
        /// [TestCase] allows parameterized tests.
        /// </summary>
        [TestCase(true)]
        public void SendMailToCustomer_WhenCalled_ReturnsTrue(bool expected)
        {
            // Act
            bool result = _customerNotification.SendMailToCustomer();

            // Assert
            Assert.That(result, Is.EqualTo(expected),
                "SendMailToCustomer() should return true when mail is sent successfully.");
        }

        [Test]
        public void SendMailToCustomer_WhenCalled_InvokesEmailServiceExactlyOnce()
        {
            // Act
            _customerNotification.SendMailToCustomer();

            // Verify
            _mockEmailService.Verify(
                m => m.SendMail(It.IsAny<string>(), It.IsAny<string>()),
                Times.Once,
                "SendMail should be called exactly once per transaction."
            );
        }

        [Test]
        public void SendMailToCustomer_MockNeverThrows_NoRealEmailSent()
        {
            Assert.DoesNotThrow(() => _customerNotification.SendMailToCustomer(),
                "No exception should be thrown — mock isolates the SMTP dependency.");
        }

        [Test]
        public void SendMailToCustomer_MockSetupWithSpecificArgs_ReturnsTrue()
        {
            // Override the generic setup with a specific-argument setup
            var specificMock = new Mock<IEmailService>();

            specificMock
                .Setup(m => m.SendMail("cust123@abc.com", "Some Message"))
                .Returns(true);

            var notification = new CustomerNotification(specificMock.Object);

            bool result = notification.SendMailToCustomer();

            Assert.That(result, Is.True);
        }
    }
}

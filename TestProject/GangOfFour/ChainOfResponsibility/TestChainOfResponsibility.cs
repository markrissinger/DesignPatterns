using DesignPatterns.GangOfFour.Behavioral.ChainOfResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.GangOfFour.ChainOfResponsibility
{
    /// <summary>
    /// Promotes decoupling a sender and its receiver by giving more 
    /// than one object the ability to handle a request.
    /// 
    /// CoR vs. Observer Pattern: In Observer, all registered objects receive 
    /// notifications in parallel, but in CoR, objects are notified in a chain. 
    /// </summary>
    public class TestChainOfResponsibility
    {
        [Fact]
        public void TestChainOfResponsibilityBehavior()
        {
            // Initialize
            IReceiver emailErrorHandler = new EmailErrorHandler(null);
            IReceiver faxErrorHandler = new FaxErrorHandler(emailErrorHandler);
            IssueRaiser issueRaiser = new(faxErrorHandler);
            Message message1 = new Message("Fax...", CoRConstants.MessagePriority.Normal);
            Message message2 = new Message("Emails...", CoRConstants.MessagePriority.High);
            Message message3 = new Message("Email...", CoRConstants.MessagePriority.Normal);
            Message message4 = new Message("Fax...", CoRConstants.MessagePriority.High);

            bool result1 = issueRaiser.RaiseMessage(message1);
            bool result2 = issueRaiser.RaiseMessage(message2);
            bool result3 = issueRaiser.RaiseMessage(message3);
            bool result4 = issueRaiser.RaiseMessage(message4);

            // Annoying to test since the example wasn't designed around returning results
            Assert.True(result1);
            Assert.False(result2);
            Assert.False(result3);
            Assert.True(result4);
        }
    }
}

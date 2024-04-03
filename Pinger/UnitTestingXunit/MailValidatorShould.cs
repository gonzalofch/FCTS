using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace UnitTesting;
    public class MailValidatorShould
    {
        [Fact]
        public void ValidateValidEmails() {
            //Arrange
            var mailValidator = new MailValidator();
            string emailAddress = "thecodercaveokgmail.com";
            //Act
            //Assert
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTesting;
public class MailValidatorShould
{
    //[Fact]
    //public void ValidateValidEmails()
    //{
    //    //Arrange
    //    var mailValidator = new MailValidator();
    //    string emailAddress = "thecodercaveok@gmail.com";
    //    //Act
    //    bool isValid = mailValidator.IsEmailValid(emailAddress);
    //    //Assert
    //    Assert.True(isValid);
    //}


    [Theory]
    [InlineData("mondongo@spam.invalido",false)]
    [InlineData("gmfloresch@gmail.com", true)]
    [InlineData("gonzalomiguel163@hotmail.com", true)]
    public void ValidateEmail(string emailAddress, bool expectation)
    {
    //arrange 
       var validador = new MailValidator();

        //act 
        bool esValido = validador.IsEmailValid(emailAddress);
        //assert
        Assert.Equal(esValido, expectation);
    }


    [Theory]
    [InlineData("mondongo@spam.com", "SPAM")]
    [InlineData("gmfloresch@gmail.com", "INBOX")]
    [InlineData("gonzaloflores@fake.com", "SPAM")]
    public void IdentifySpam(string emailAddress, string expectation)
    {
        //arrange

        var validador = new MailValidator();
        //act
        string resultado = validador.IsSpam(emailAddress);

        //assert
        Assert.Equal(resultado, expectation);

    }
    [Fact]
    public void RaiseErrorWhenEmailIsEmpty()
    {
        //arrange
        var validador = new MailValidator();
        //act

        //assert    
        Assert.Throws<EmailNotProvidedException>(() => validador.IsEmailValid(null));
    }
}

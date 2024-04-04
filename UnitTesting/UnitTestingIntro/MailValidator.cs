using System;
using System.Text.RegularExpressions;

namespace UnitTesting;
public class MailValidator
{
    public bool IsEmailValid(string emailAddress)
    {
        if (string.IsNullOrEmpty(emailAddress))
            throw new EmailNotProvidedException();
        Regex expRegular = new Regex(@"^[\w0-9.%+-]+@[\w0-9.-]+\.[\w]{2,6}$");
        return expRegular.IsMatch(emailAddress); //devuelve true si cumple
    }
    public string IsSpam (string emailAddress)
    {
        if(string.IsNullOrEmpty(emailAddress)) throw new EmailNotProvidedException();
        List<string> spamDomains= new List<string>() { "spam.com","dodgy.com","spam.com","mondongo.com","fake.com"};
        return spamDomains.Any(d => emailAddress.Contains(d)) ? "SPAM" : "INBOX";
    }
}
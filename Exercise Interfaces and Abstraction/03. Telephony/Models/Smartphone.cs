using Telephony.Models.Interfaces;

namespace Telephony.Models;

public class Smartphone : IBrowsing, ICalling
{
    public string Browse(string url)
    {
        if (HasDigitsInIt(url))
        {
            throw new ArgumentException("Invalid URL!");
        }
        return $"Browsing: {url}!";
    }

    public string Calling(string phoneNum)
    {
        if (!IsAllDigits(phoneNum))
        {
            throw new ArgumentException("Invalid number!");
        }
        return $"Calling... {phoneNum}";
    }
    private bool IsAllDigits(string number) => number.All(c => char.IsDigit(c));

    private bool HasDigitsInIt(string number) => number.Any(c => char.IsDigit(c));

}

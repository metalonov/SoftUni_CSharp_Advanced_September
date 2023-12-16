using Telephony.Models.Interfaces;

namespace Telephony.Models;

public class StationaryPhone : ICalling
{
    public string Calling(string phoneNum)
    {
        if (!IsAllDigits(phoneNum))
        {
            throw new ArgumentException("Invalid number!");
        }
        return $"Dialing... {phoneNum}";
    }
    private bool IsAllDigits(string number) => number.All(c => char.IsDigit(c));

}

using Telephony.Models;
using Telephony.Models.Interfaces;

namespace Telephony;
public class StartUp
{
    public static void Main()
    {
        string[] phoneNumbers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string[] urls = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        ICalling call;

        foreach (string currentPhoneNum in phoneNumbers)
        {
            try
            {
                if (currentPhoneNum.Length == 10)
                {
                    call = new Smartphone();
                    Console.WriteLine(call.Calling(currentPhoneNum));
                }
                else if (currentPhoneNum.Length == 7)
                {
                    call = new StationaryPhone();
                    Console.WriteLine(call.Calling(currentPhoneNum));
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        foreach (var browsing in urls)
        {
            try
            {
                IBrowsing browse = new Smartphone();
                Console.WriteLine(browse.Browse(browsing));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}

/*
0882134215 0882134333 0899213421 0558123 3333123
http://softuni.bg http://youtube.com http://www.g00gle.com
*/
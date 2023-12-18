public class Program
{
    static void Main()
    {
        string[] initialInputLine = Console.ReadLine()
                .Split(',', StringSplitOptions.RemoveEmptyEntries);

        Dictionary<int, double> bankLedger = new();

        foreach (var row in initialInputLine)
        {
            string[] line = row
                .Split('-', StringSplitOptions.RemoveEmptyEntries);
            int key = int.Parse(line[0]);
            double value = double.Parse(line[1]);
            bankLedger.Add(key, value);
        }

        string commands;

        while ((commands = Console.ReadLine()) != "End")
        {
            string[] commandArgs = commands
                .Split();
            try
            {
                int accountNumber = int.Parse(commandArgs[1]);
                double sum = double.Parse(commandArgs[2]);
                if (!bankLedger.Any(a => a.Key == accountNumber))
                {
                    throw new ArgumentException(InvalidAccount.Account);
                }
                if (commandArgs[0] == "Deposit")
                {
                    double displayedSum = bankLedger[accountNumber] += sum;
                    Console.WriteLine($"Account {accountNumber} has new balance: {displayedSum:F2}");
                }
                else if (commandArgs[0] == "Withdraw")
                {

                    double displayedSum = bankLedger[accountNumber] -= sum;
                    if (displayedSum < 0)
                    {
                        bankLedger[accountNumber] += sum;
                        throw new ArgumentException(InsufficientBalance.Balance);
                    }
                    Console.WriteLine($"Account {accountNumber} has new balance: {displayedSum}");
                }
                else
                {
                    throw new ArgumentException(InvalidCommand.Command);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Enter another command");
        }
    }
}

public class InvalidAccount
{
    public const string Account = "Invalid account!";
}

public class InvalidCommand
{
    public const string Command = "Invalid command!";
}

public class InsufficientBalance
{
    public const string Balance = "Insufficient balance!";
}

/*
1-45.67,2-3256.09,3-97.34
Deposit 1 50
Withdraw 3 100
End
*/
/*
1473653-97.34,44643345-2347.90
Withdraw 1473653 150.50
Deposit 44643345 200
Block 1473653 30
Deposit 1 30
End
*/
public class Program
{
    static void Main()
    {
        List<Card> deck = new();
        string[] inputs = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        foreach (var item in inputs)
        {
            try
            {
                string[] cardData = item
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Card card = CreateCard(cardData[0], cardData[1]);
                deck.Add(card);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        Console.Write(string.Join(" ", deck));
    }

    static Card CreateCard(string face, string suit)
    {
        Card card = new Card(face, suit);
        return card;
    }
}

public class Card
{
    private string face;
    private string suit;
    private string[] faceCollection = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
    public Card(string face, string suit)
    {
        Face = face;
        Suit = suit;
    }

    public string Suit
    {
        get
        {
            return suit;
        }
        private set
        {
            if (value == "S")
            {
                suit = "♠";
            }
            else if (value == "H")
            {
                suit = "♥";
            }
            else if (value == "D")
            {
                suit = "♦";
            }
            else if (value == "C")
            {
                suit = "♣";
            }
            else
            {
                throw new ArgumentException("Invalid card!");
            }
        }
    }
    public string Face
    {
        get
        {
            return face;
        }
        private set
        {
            if (faceCollection.Contains(value))
            {
                face = value;
            }
            else
            {
                throw new ArgumentException("Invalid card!");
            }
        }
    }
    public override string ToString()
    {
        return $"[{Face}{Suit}]";
    }
}
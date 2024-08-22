namespace PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("How many cards would you like: ");
            string? numberOfCardsChosen = Console.ReadLine();
            bool parseSuccessful = int.TryParse(numberOfCardsChosen, out int cardNumber);

            while (!parseSuccessful)
            {
                Console.Write("Enter a valid number of cards you would like: ");
                numberOfCardsChosen = Console.ReadLine();
                parseSuccessful = int.TryParse(numberOfCardsChosen, out cardNumber);
            }

            string[] returnedCards = CardPicker.PickSomeCards(cardNumber);
            foreach (string card in returnedCards) Console.WriteLine(card);
        }
    }
}

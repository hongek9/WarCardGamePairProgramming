using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarCardGame_PairProgramming
{
    class Program
    {
        enum FaceCards
        {
            jack = 11,
            King = 13,
            Queen = 12,
            Ace = 14
        }
        static void Main(string[] args)
        {
            // Create a deck, jack = 11, queen = 12, king = 13, ace = 14

            List<int> deck = new List<int> { 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 6, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 9, 9, 9, 9, 10, 10, 10, 10, 11, 11, 11, 11, 12, 12, 12, 12, 13, 13, 13, 13, 14, 14, 14, 14 };


            Random rnd = new Random();
            // split the deck between the two players randomly

            List<int> playerOneHand = new List<int> { };

            List<int> playerTwoHand = new List<int> { };

            for (int i = 51; i >= 0; i--)
            {
                int randomNum = rnd.Next(i);

                if (i % 2 == 0)
                {
                    int cardValue = deck[randomNum];
                    playerOneHand.Add(cardValue);
                    deck.Remove(deck[randomNum]);
                }
                else
                {
                    int cardValue = deck[randomNum];
                    playerTwoHand.Add(cardValue);
                    deck.Remove(deck[randomNum]);
                }
            }

            void PlayWarRound(int numOfCards, bool playerOneWon)
            {
                for (int i = 0; i < numOfCards; i++)
                {
                    playerOneHand.Remove(playerOneHand[i]);
                    playerTwoHand.Remove(playerTwoHand[i]);
                    if (playerOneWon)
                    {
                        playerOneHand.Add(playerOneHand[i]);
                        playerOneHand.Add(playerTwoHand[i]);
                    }
                    else
                    {
                        playerTwoHand.Add(playerOneHand[i]);
                        playerTwoHand.Add(playerTwoHand[i]);
                    }
                }
            }
            string FaceCardConversion(int FaceCardValue)
            {
                //We want take a card value and convert to corresponding enum value
                //if(FaceCardValue >= 11)
                //{
                //FaceCardValue == FaceCards(FaceCardValue);

                //}
                
                switch (FaceCardValue)
                {

                    case 11:
                        return "Jack";

                    case 12:
                        return "Queen";

                    case 13:
                        return "King";

                    case 14:
                        return "Ace";

                    default:
                        return FaceCardValue.ToString();
                }
            }

            while (playerOneHand.Count() > 0 && playerTwoHand.Count() > 0)
            {
                int playerOneCard = playerOneHand[0];
                Console.WriteLine($"Player One: {FaceCardConversion (playerOneCard)}");
                int playerTwoCard = playerTwoHand[0];
                Console.WriteLine($"Player Two: {FaceCardConversion (playerTwoCard)}");
                if (playerOneCard > playerTwoCard)
                {
                    PlayWarRound(1, true);
                    Console.WriteLine("Player One Won!");
                    Console.WriteLine($"Player One Deck Count: {playerOneHand.Count()}");
                    Console.WriteLine($"Player Two Deck Count: {playerTwoHand.Count()}");

                }
                else if (playerTwoCard > playerOneCard)
                {
                    PlayWarRound(1, false);
                    Console.WriteLine("Player Two Won!");
                    Console.WriteLine($"Player One Deck Count: {playerOneHand.Count()}");
                    Console.WriteLine($"Player Two Deck Count: {playerTwoHand.Count()}");
                }
                else
                {
                    Console.WriteLine("War Time!");
                    Console.WriteLine($"Player One: {FaceCardConversion (playerOneHand[4])}");
                    Console.WriteLine($"Player Two: {FaceCardConversion (playerTwoHand[4])}");

                    if (playerOneHand[4] > playerTwoHand[4])
                    {
                        PlayWarRound(5, true);
                        Console.WriteLine("Player One Won!");
                        Console.WriteLine($"Player One Deck Count: {playerOneHand.Count()}");
                        Console.WriteLine($"Player Two Deck Count: {playerTwoHand.Count()}");
                    }
                    else if (playerTwoHand[4] > playerOneHand[4])
                    {
                        PlayWarRound(5, false);
                        Console.WriteLine("Player Two Won!");
                        Console.WriteLine($"Player One Deck Count: {playerOneHand.Count()}");
                        Console.WriteLine($"Player Two Deck Count: {playerTwoHand.Count()}");
                    }
                }
                Console.WriteLine("Press any key to play the next hand.");
                Console.ReadKey();
                Console.Clear();
            }

            if (playerOneHand.Count() > 0)
            {
                Console.WriteLine("Player One Wins!");
            }
            else
            {
                Console.WriteLine("Player Two Wins!");


            }
        }
    }
}
        
    
   
                

        
    


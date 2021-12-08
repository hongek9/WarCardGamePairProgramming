using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarCardGame_PairProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a deck, jack = 11, queen = 12, king = 13, ace = 14

            List<int> deck = new List<int> { 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 6, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 9, 9, 9, 9, 10, 10, 10, 10, 11, 11, 11, 11, 12, 12, 12, 12, 13, 13, 13, 13, 14, 14, 14, 14 };

            // parrallel array for shuffling

            Double[] order = new Double[52];

            Random rnd = new Random();



            // split the deck between the two players randomly



            List<int> playerOneHand = new List<int> { };

            List<int> playerTwoHand = new List<int> { };

            int playerOneCount = 26;

            int playerTwoCount = 26;

            for (int i = 51; i == 0; i--)
            {
                int randomNum = rnd.Next(i);

                Console.WriteLine(randomNum);

            if (i % 0 == 0)
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
            
            foreach (int i in playerTwoHand)
            {
                Console.WriteLine(i);
            }
                Console.ReadLine();

             while(playerOneCount > 0 && playerTwoCount > 0)
             {
              
             }
        }
    }
}

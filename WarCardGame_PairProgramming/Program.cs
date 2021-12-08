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
            
           

             while(playerOneHand.Count() > 0 && playerTwoHand.Count() > 0)
             {
                int playerOneCard = playerOneHand[0];
                Console.WriteLine(playerOneCard);
                int playerTwoCard = playerTwoHand[0];
                Console.WriteLine(playerTwoCard);
                if (playerOneCard > playerTwoCard)
                {
                    playerOneHand.Remove(playerOneHand[0]);
                    playerTwoHand.Remove(playerTwoHand[0]);
                    playerOneHand.Add(playerOneHand[0]);
                    playerOneHand.Add(playerTwoHand[0]);
                    Console.WriteLine("Player One Won!");
                }
                else if (playerTwoCard > playerOneCard)
                {
                    playerOneHand.Remove(playerOneHand[0]);
                    playerTwoHand.Remove(playerTwoHand[0]);
                    playerTwoHand.Add(playerOneHand[0]);
                    playerTwoHand.Add(playerTwoHand[0]);
                    Console.WriteLine("Player Two Won!");
                }
                else 
                {
                    Console.WriteLine("War Time!");
                    Console.WriteLine(playerOneHand[4]);
                    Console.WriteLine(playerTwoHand[4]);
                    if (playerOneHand[4] > playerTwoHand[4])
                    {
                        playerOneHand.Remove(playerOneHand[0]);
                        playerOneHand.Remove(playerOneHand[1]);
                        playerOneHand.Remove(playerOneHand[2]);
                        playerOneHand.Remove(playerOneHand[3]);
                        playerOneHand.Remove(playerOneHand[4]);
                        playerTwoHand.Remove(playerTwoHand[0]);
                        playerTwoHand.Remove(playerTwoHand[1]);
                        playerTwoHand.Remove(playerTwoHand[2]);
                        playerTwoHand.Remove(playerTwoHand[3]);
                        playerTwoHand.Remove(playerTwoHand[4]);

                        playerOneHand.Add(playerOneHand[0]);
                        playerOneHand.Add(playerOneHand[1]);
                        playerOneHand.Add(playerOneHand[2]);
                        playerOneHand.Add(playerOneHand[3]);
                        playerOneHand.Add(playerOneHand[4]);
                        playerOneHand.Add(playerTwoHand[0]);
                        playerOneHand.Add(playerTwoHand[1]);
                        playerOneHand.Add(playerTwoHand[2]);
                        playerOneHand.Add(playerTwoHand[3]);
                        playerOneHand.Add(playerTwoHand[4]);
                    }
                    else if (playerTwoHand[4] > playerOneHand[4])
                    {
                        playerOneHand.Remove(playerOneHand[0]);
                        playerOneHand.Remove(playerOneHand[1]);
                        playerOneHand.Remove(playerOneHand[2]);
                        playerOneHand.Remove(playerOneHand[3]);
                        playerOneHand.Remove(playerOneHand[4]);
                        playerTwoHand.Remove(playerTwoHand[0]);
                        playerTwoHand.Remove(playerTwoHand[1]);
                        playerTwoHand.Remove(playerTwoHand[2]);
                        playerTwoHand.Remove(playerTwoHand[3]);
                        playerTwoHand.Remove(playerTwoHand[4]);

                        playerTwoHand.Add(playerOneHand[0]);
                        playerTwoHand.Add(playerOneHand[1]);
                        playerTwoHand.Add(playerOneHand[2]);
                        playerTwoHand.Add(playerOneHand[3]);
                        playerTwoHand.Add(playerOneHand[4]);
                        playerTwoHand.Add(playerTwoHand[0]);
                        playerTwoHand.Add(playerTwoHand[1]);
                        playerTwoHand.Add(playerTwoHand[2]);
                        playerTwoHand.Add(playerTwoHand[3]);
                        playerTwoHand.Add(playerTwoHand[4]);

                    }
                   
                }
                Console.ReadKey();
             }
        }
    }
}

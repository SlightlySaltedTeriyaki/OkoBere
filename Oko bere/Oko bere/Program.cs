using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oko_bere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vítejte ve hře oko bere.");

            Player player1 = new Player("", 0);
            Player player2 = new Player("", 0);
            Player player3 = new Player("", 0);
            Player player4 = new Player("", 0);
            Player player5 = new Player("", 0);
            Player player6 = new Player("", 0);

            bool check = true;
            do
            {
                int playersNumber = 0;
                Console.WriteLine("Maximální počet hráčů je 6.");
                players:
                try
                {
                    Console.Write("Zadejte počet hráčů: ");
                    playersNumber = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    goto players;
                }

                if (playersNumber > 6)
                {
                    Console.WriteLine("Zadal jste moc velký počet hráčů.");
                    goto players;
                }else if(playersNumber < 1)
                {
                    Console.WriteLine("Zadal jste moc malý počet hráčů.");
                    goto players;
                }

                string playerName;
                if (playersNumber == 1)
                {
                    Console.WriteLine("Zadejte jméno hráče:");
                    player1.name = Console.ReadLine();
                }
                
                if(playersNumber > 1)
                {
                    Console.WriteLine("Zadejte jméno prvního hráče:");
                    player1.name = Console.ReadLine();
                }
                if(playersNumber == 2 || playersNumber > 2){
                    Console.WriteLine("Zadejte jméno druhého hráče:");
                    player2.name = Console.ReadLine();
                }
                if (playersNumber == 3 || playersNumber > 3)
                {
                    Console.WriteLine("Zadejte jméno třetího hráče:");
                    player3.name = Console.ReadLine();
                }
                if (playersNumber == 4 || playersNumber > 4)
                {
                    Console.WriteLine("Zadejte jméno čtvrtého hráče:");
                    player4.name = Console.ReadLine();
                }
                if (playersNumber == 5 || playersNumber > 5)
                {
                    Console.WriteLine("Zadejte jméno pátého hráče:");
                    player5.name = Console.ReadLine();
                }
                if (playersNumber == 6)
                {
                    Console.WriteLine("Zadejte jméno šestého hráče:");
                    player6.name = Console.ReadLine();
                }


                bool nextCard = true;
                string answer;
                int count = 0;
                string player = "";
                for (int i = 1; i <= playersNumber; i++)
                {
                    nextCard = true;
                    while (nextCard)
                    {
                        switch (i)
                        {
                            case 1:
                                player = player1.name;
                                break;
                            case 2:
                                player = player2.name;
                                break;
                            case 3:
                                player = player3.name;
                                break;
                            case 4:
                                player = player4.name;
                                break;
                            case 5:
                                player = player5.name;
                                break;
                            case 6:
                                player = player6.name;
                                break;
                        }


                        Console.WriteLine("Nyní hraje: " + player);
                        count = count + GetCard.RandomCard();
                        nextCard:
                        Console.WriteLine("Váš počet je: " + count);
                        Console.WriteLine("Chcete další kartu? [Y/N]");
                        answer = Console.ReadLine();
                        answer.ToLower();
                        if (answer == "y")
                        {
                            count = count + GetCard.RandomCard();
                            if (count > 21)
                            {
                                Console.WriteLine("Prohrál jsi.\n");
                                nextCard = false;
                                
                            }
                            else
                            {
                                goto nextCard;
                            }
                        }
                        else if (answer == "n")
                        {
                            nextCard = false;
                            Console.WriteLine("\n");
                        }
                        else
                        {
                            Console.WriteLine("Zadal jste nesprávnou odpověď.");
                            goto nextCard;
                        }

                        switch (i)
                        {
                            case 1:
                                player1.count = count;
                                count = 0;
                                break;
                            case 2:
                                player2.count = count;
                                count = 0;
                                break;
                            case 3:
                                player3.count = count;
                                count = 0;
                                break;
                            case 4:
                                player4.count = count;
                                count = 0;
                                break;
                            case 5:
                                player5.count = count;
                                count = 0;
                                break;
                            case 6:
                                player6.count = count;
                                count = 0;
                                break;
                        }
                        Console.WriteLine(player1.name + " " + player1.count + "\n" + 
                                          player2.name + " " + player2.count + "\n" + 
                                          player3.name + " " + player3.count + "\n" + 
                                          player4.name + " " + player4.count + "\n" + 
                                          player5.name + " " + player5.count + "\n" + 
                                          player6.name + " " + player6.count + "\n");
                    }
                }

                if (playersNumber > 1)
                {
                    int[] results = { player1.count, player2.count, player3.count, player4.count, player5.count, player6.count };
                    int nearest = results.OrderBy(x => Math.Abs((long)x - 21)).First();

                    if (player1.count == nearest && player2.count == nearest || player1.count == nearest && player3.count == nearest || player1.count == nearest && player4.count == nearest || player1.count == nearest && player5.count == nearest || player1.count == nearest && player6.count == nearest)
                    {
                        string winners = "Hráči ";
                        if (player1.count == nearest && player1.count <= 21)
                        {
                            winners = winners + player1.name;
                        }
                        if (player2.count == nearest && player2.count <= 21)
                        {
                            if (winners == "Hráči ")
                            {
                                winners = winners + player2.name;
                            }
                            else
                            {
                                winners = winners + ", " + player2.name;
                            }
                        }
                        if (player3.count == nearest && player3.count <= 21)
                        {
                            if (winners == "Hráči ")
                            {
                                winners = winners + player3.name;
                            }
                            else
                            {
                                winners = winners + ", " + player3.name;
                            }
                        }
                        if (player4.count == nearest && player4.count <= 21)
                        {
                            if (winners == "Hráči ")
                            {
                                winners = winners + player4.name;
                            }
                            else
                            {
                                winners = winners + ", " + player4.name;
                            }
                        }
                        if (player5.count == nearest && player5.count <= 21)
                        {
                            if (winners == "Hráči ")
                            {
                                winners = winners + player5.name;
                            }
                            else
                            {
                                winners = winners + ", " + player5.name;
                            }
                        }
                        if (player6.count == nearest && player6.count <= 21)
                        {
                            winners = winners + " a " + player6.name;
                        }

                        if(winners == "Hráči ")
                        {
                            Console.WriteLine("Nikdo nevyhrál.");
                        }
                        else
                        {
                            Console.WriteLine(winners + " vyhráli!");
                        }
                        
                    }
                    else
                    {
                        string winner = Winner.Weiner(nearest, player1.count, player2.count, player3.count, player4.count, player5.count, player6.count, player1.name, player2.name, player3.name, player4.name, player5.name, player6.name);
                        if(winner == "")
                        {
                            Console.WriteLine("Nikdo nevyhrál.");
                        }
                        else
                        {
                            Console.WriteLine("Hráč " + winner + " vyhrál!");
                        }
                    }
                }else
                {
                    Console.WriteLine("Váš počet je: " + player1.count);
                }


                again:
                Console.WriteLine("Chcete hrát znovu? [Y/N]");
                answer = Console.ReadLine();
                answer.ToLower();
                if (answer == "y")
                {                   
                }
                else if (answer == "n")
                {
                    check = false;
                }
                else
                {
                    Console.WriteLine("Zadal jste nesprávnou odpověď.");
                    goto again;
                }
            } while (check);
        }
    }
}

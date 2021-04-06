using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //added this for text writing
using Casino; //can be added after making a reference in the twentyone namespace. Don't forget to build Casino first so the DLL shows up. (in Bin)
using Casino.TwentyOne;
using System.Data.SqlClient;
using System.Data;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";

            Console.WriteLine(
                $"Welcome to {casinoName}. " +
                "\nLet's start by telling me your name.");
            string playerName = Console.ReadLine();
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write($"{exception.Id} | ");
                    Console.Write($"{exception.ExceptionType} | ");
                    Console.Write($"{exception.ExceptionMessage} | ");
                    Console.Write($"{exception.TimeStamp} | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter integers only");
            }         

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();//unique identifier
                using (StreamWriter file = new StreamWriter(@"C:\Users\Lyman\Desktop\coding\portfolio_pieces\tech_academy_projects\tech-academy-C-sharp-projects\logs\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }

                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("Something you entered wasn't right");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred. Please contact your System Administrator");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();
        }

        private static void UpdateDbWithException(Exception ex)
        {
            //the connection string is found in the properties panel of the DB
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                        ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string queryString = @"INSERT INTO Exceptions (Exceptiontype, Exceptionmessage, TimeStamp) VALUES
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                        ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string queryString = @"SELECT Id, ExceptionType, Exceptionmessage, TimeStamp FROM Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions;
        }
    }
}

//using a chained constructor
//Player newPlayer = new Player("Lyman");
//creating a constant
//const string casinoName = "Grand Hotel and Casino";

//using datetime
//datetime is a struct, so it can't be null
//DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
//DateTime yearOfGraduation = new DateTime(2020, 5, 25, 9, 30, 00);

//TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;

//Write text to file
//tring text = "here is some text";
//File.WriteAllText(
//    @"C:\Users\Lyman\Desktop\coding\portfolio_pieces\tech_academy_projects\tech-academy-C-sharp-projects\logs\log.txt",
//    text);
//The @ symbol means to read this text as is, that way you don't need double \\
//read text from file
//string text = File.ReadAllText(@"C:\Users\Lyman\Desktop\coding\portfolio_pieces\tech_academy_projects\tech-academy-C-sharp-projects\logs\log.txt");


//Deck deck = new Deck();
//deck.Shuffle(3);

//foreach (Card card in deck.Cards)
//{
//    Console.WriteLine(card.Face + " of " + card.Suit);
//}
//Console.WriteLine(deck.Cards.Count);
//Console.ReadLine();

////Lambda Function.
////int count = deck.Cards.Count(x => x.Face == Face.Ace); //finds the amount of aces in the deck
////List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList(); //filters the list of cards based on face
//List<int> intList = new List<int>() { 1, 2, 3, 4, 5, 100, 305 };
//int sum = intList.Sum(x => x+5); //other available list functions are max(), .min(), 



//Value Types vs. Reference Types
//Card card1 = new Card();
//Card card2 = card1;
//card1.Face = Face.Eight;
//card2.Face = Face.King;
//The above code, if card was a class, would just end up with both cards with the face King
//because card 2 and card1 would be pointing to the same place. When changed to a struct
//card1 and card2 are separate instances, and when you change card2 it only effects card2.


//operator overloading
//Game game = new TwentyOneGame();
//game.Players = new List<Player>();
//Player player = new Player();
//player.Name = "Lyman";
//game += player;
//game -= player;

//polymorphism
//Game game = new TwentyOneGame();
//This could be useful if you are making a list of games that are all 
//different sub-classes. you make the list type "game" and then you can
//add all different game types.


//simple inheritance
//TwentyOneGame game = new TwentyOneGame();
//game.Players = new List<string>() { "Lyman", "Banuels", "Joe", "Kurt" };
//game.ListPlayers();
//game.Play();
//Console.ReadLine();


//Make a card
//Card cardOne = new Card();
//cardOne.Face = "Queen";
//cardOne.Suit = "Spades";

//Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);

//make a deck
//Deck deck = new Deck();
//deck.Cards = new List<Card>();
//deck.Cards.Add(cardOne);

//with Constructor



//int timesShuffled = 0;

//The out paramter will take a variable into the function and 
//automatically return it to that variable. in this case, we are 
//returning timesShuffled to the variable itself, so after the sub-program is 
//run, we can see that it's been shuffled 3 times.
//deck = Shuffle(deck: deck, out timesShuffled, times: 3); //the deck: and times: are just names for the parameter
//deck = Shuffle(deck, 3);



//Console.WriteLine("Times Shuffled: {0}", timesShuffled);


//you could methof overload this way, or add a parameter to the above
//public static Deck Shuffle(Deck deck, int times)
//{
//    for (int i = 0; i < times; i++)
//    {
//        deck = Shuffle(deck);
//    }
//    return deck;
//}

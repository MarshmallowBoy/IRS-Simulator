using System;

namespace Multi
{
    class Program
    {

        static void Main()
        {
            // Vars //
            Random rnd = new Random();
            int rouletteInt = 0;
            float money = 200f;
            bool hasEncounteredBank = false;

            Console.WriteLine("Welcome To T And D's Casino");
            Console.WriteLine("(Totally Not A Place Where You Get Scammed)");
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Oh, That Is A Good Name, " + name);
            Start();

            void Start()
            {
                if (money <= -100)
                {
                    if (hasEncounteredBank == false)
                    {
                        int debtRND = rnd.Next(1, 30);
                        if (debtRND == 1)
                        {
                            Console.WriteLine("Your Debt Got To High, And The Feds Assassinated You.");
                            Console.WriteLine("Don't Gamble Kids");
                            Main();
                        }
                        if (debtRND == 2)
                        {
                            Console.WriteLine(name + ", Died Of Tax Evasion, What An Idiot");
                            Console.WriteLine("Don't Gamble Kids");
                            Main();
                        }
                        if (debtRND == 3)
                        {
                            Console.WriteLine("You Got Too Much Debt, And Died Of Stupidity");
                            Console.WriteLine("Don't Gamble Kids");
                            Main();
                        }
                        if (debtRND == 4)
                        {
                            Console.WriteLine("The Money Caught Up To You, You Died");
                            Console.WriteLine("Don't Gamble Kids");
                            Console.WriteLine("Sorry" + name);
                            Main();
                        }
                        if (debtRND == 5)
                        {
                            Console.WriteLine("You Broke A Knee While Past Out After A Good Game, You Had Too Crappy Credit For Insurance To Cover It.");
                            Console.WriteLine("You Died After Someone Was Chasing You And You Couldn't Outrun Them");
                            Console.WriteLine("Don't Gamble Kids");
                            Main();
                        }
                        if (debtRND == 6)
                        {
                            Console.WriteLine("You Were Stuggling In Debt, So Much To The Point Where You Were Selling Feet Pics To Wierdo's On The Internet");
                            Console.WriteLine("Unfornately, Your Feet Are Full Of Ugly Calices, And Nobody With Money Gonna Like That.");
                            Console.WriteLine("Don't Gamble Kids");
                            Main();
                        }
                        if (debtRND == 7)
                        {
                            Console.WriteLine("You Didn't Have Enough Drug Money.");
                            Console.WriteLine("So Your Local Crackhead Killed You");
                            Console.WriteLine("Don't Gamble Kids");
                            Main();
                        }
                        if (debtRND == 8)
                        {
                            Console.WriteLine("The bank found your OnlyFans and they took all the feet pic revenue, and ended you");
                            Console.WriteLine("Don't Gamble Kids");
                            Main();
                        }
                        if (debtRND == 9)
                        {
                            Console.WriteLine("You Have No Money So You Commited Tax Evasion, So You Joined Mr. Krabs In His Battle To Save A Couple Bucks.");
                            Console.WriteLine("You Lifed Your M4A1 But Someone Shot Your In The Chest.");
                            Console.WriteLine("(You Probably Could Have Just Sold The Gun, Although You Might Want To Buy A Pistol So Your Still Protected)");
                            Console.WriteLine("Don't Gamble Kids");
                            Console.WriteLine("Unless You're Bill Gates");
                            Console.WriteLine("Cuz He Has A Crap Ton Of Money");
                            Main();
                        }
                        if (debtRND == 10)
                        {
                            Console.WriteLine("");
                        }

                        if (debtRND > 10)
                        {
                            hasEncounteredBank = true;
                            Console.WriteLine("You Couldn't Pay the Bank, So the bank gave you $50 to win back your debt and if you don't get $100 Soon... You Will Die. ");
                            money = 50;
                            Start();
                        }

                    }
                    else
                    {
                        Console.WriteLine("You failed to pay them back");
                        Console.WriteLine("Don't Gamble Kids");
                        Console.WriteLine("You Died Of Done Doing A Dumb");
                        Main();
                    }
                }


                Console.WriteLine("What would you like to play?");
                Console.WriteLine("1 - Roulette");
                string gameAnswer = Console.ReadLine();

                if (gameAnswer == "1")
                {
                    Roulette();
                }


            }

            void Roulette()
            {
                Console.WriteLine("You Have, $" + money + ".");
                int rouletteRND = rnd.Next(1, 36);
                Console.WriteLine("How Much You Bet?");
                string Bet = Console.ReadLine();
                float moneyBet = float.Parse(Bet);
                money = money - moneyBet;


                Console.WriteLine("Guess What Number?!?!!?");
                string rouletteString = Console.ReadLine();
                rouletteInt = int.Parse(rouletteString);

                if (rouletteInt == rouletteRND)
                {
                    moneyBet = moneyBet * 5;
                    money = moneyBet + money;

                    Console.WriteLine("You Win!");
                    Console.WriteLine("You Got What You Put In x5");
                    Console.WriteLine("You Have, $" + money + ".");
                    Start();
                }
                else
                {
                    Console.WriteLine("You're A Loser Wooza");
                    Console.WriteLine("You Picked, " + rouletteInt + ". But it was, " + rouletteRND);
                    Console.WriteLine("You Lost, $" + moneyBet + ".");
                    moneyBet = 0;
                    money = moneyBet + money;
                    Console.WriteLine("You Have, $" + money + ".");
                    Console.WriteLine("Your Enemy Antonio Picked, " + rouletteRND + ". And Won.");
                    Start();
                }

            }

        }
    }
}

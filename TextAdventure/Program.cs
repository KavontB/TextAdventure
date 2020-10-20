using System;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            String choice;
            Console.WriteLine("Hello there, please enter your name.");
            String name = Console.ReadLine();
            Console.WriteLine("You are going on a late night walk with your dog in your neighborhood. The streetlights illuminate " +
                "your path as your dog pulls you along the sidewalk.");
            Console.WriteLine("What is the name of your dog?");
            String dogName = Console.ReadLine();
            Console.WriteLine($"So there y'all are {name} and {dogName} walking down the street until you see something " +
            $"that makes your heart stop. At the end of the sidewalk where the streetlights don't reach stands a shadowy figure." +
            $"Your dog starts growling at it and suddenly lunges at the figure, causing you to drop the leash.");
            Console.WriteLine($"Now {name}, you have 3 choices. To make a choice type the word that is typed in all caps " +
                $"that corresponds with your choice.",
            $"1)You can FOLLOW your dog and confront the shadowy figure, 2)you can attempt to GRAB  " +
            $"the leash and pull {dogName} back, or 3) you can stay back and WATCH what happens.");
          
                choice = Console.ReadLine();
            String lowerChoice = choice.ToLower();

            while (lowerChoice.Equals("follow") == false && lowerChoice.Equals("grab") == false && lowerChoice.Equals("watch") == false) {
                Console.WriteLine("You didn't choose from the choice above. Please choose either follow, grab, or watch!!");
                choice = Console.ReadLine();
                lowerChoice = choice.ToLower();
            }
            if (lowerChoice.Equals("follow"))
            {
                Follow(name,dogName);

            }
            else if (lowerChoice.Equals("grab"))
            {
                Grab(name, dogName);

            }
            else if (lowerChoice.Equals("watch"))
            {
                Watch(name, dogName);
            }
            else
            {
                Console.WriteLine("Please choose from the choices given to you");
                choice = Console.ReadLine();
                lowerChoice = choice.ToLower();

            }
        }
        static void Follow(String name,String dogName)
        {
            Console.WriteLine("You decide to chase after your dog! The figure quickly hovers away into the " +
                $"night making it hard to see. {dogName} though keeps running full speed at it. You are starting " +
                $"to run out of stamina.Keeping up with {dogName} gets harder as seconds turn into minutes. " +
                $"You have to stop to catch " +"your breath causing {dogName} and the figure to run off into the" +
                " night. After you catch your breath you decide " + $"that it would be pointless to just chase " +
                $"into the nothingness of the night so you run home as fast as you can" +$"so you can get in " +
                $"your car and look for {dogName}. As soon as you make it to the front door you hear" +
                $" somebody yelling your name.");

            Console.WriteLine($"{name}...{name}....");
            Console.WriteLine($"You hear it coming from across the street. You turn around and see your neighbor Lester walking your dog," +
                $" {dogName} towards your house. You invite him in so you can ask him where he found your dog. He explained that " +
                $"his wife normally goes on midnight runs in her trenchcoat and she wanted to say hi to you and {dogName}. " +
                $"But, when she saw {dogName} running at her she became scared and ran away. She got bit and was taken to the hospital. " +
                $" So Lester decided to bring your dog back. what a good guy. You Won(Happy End)");
        }
        static void Grab(String name, String dogName)
        {
            Console.WriteLine($"You reach out and grab the leash before your dog can charge at the figure but, doing so causes you to lose your " +
             $"balance and fall on the sidewalk hitting your head. You can feel the presence of the figure approaching fast.{dogName} growls at the" +
             $" figure as it moves closer. As you try to pull yourself off the ground you can hear the growling stop. You look up to see" +
             $" a mysterious man feeding your dog something. You yell at him telling him to get away from your dog but it " +
             $"turns out he wasn't a bad guy. He just got a little turned around and he needed help getting to a gas station " +
             $"because his hummer ran out of gas. You use your phone and call him an uber then leave the area. You learned a valuable" +
             $"lesson today, never judge a book by its cover. You did ok?(happy end?)");
        }
        static void Watch(String name, String dogName)
        {
            Console.WriteLine($"You chose to stay back and watch what happens. This turns out to be the biggest mistake of your life." +
                $"That weird figure you saw? Turns out he was a police officer, and now {dogName} is attacking him and your on the" +
                $" side just watching. As soon as {dogName} drags the officer under the streetlight you realize your grave mistake." +
                $"You pull {dogName} off and apologize profusely to the officer. Too little too late! The officer places you " +
                $"under arrest and charges you with assault with a deadly weapon. You are sentenced to life in prison no parole." +
                $"You Lose.(unhappy end) ");
        }
    }

}


using System;

namespace JoshsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string weapon = "";
            string boss1 = "";
            string bossresult1 = "";
            string boss2 = "";
            string groomsmanAsk = "";
            string response = "";
            int counter = 0;


            while (name.ToLower() != "blake" && name.ToLower() != "derek" && name.ToLower() != "jordan")
            {
                Console.WriteLine("Welcome to the game. What is your name?");
                name = Console.ReadLine();
                if (name.ToLower() != "blake" && name.ToLower() != "derek" && name.ToLower() != "jordan" && name.ToLower() != "alyssa")
                {
                    Console.WriteLine("Well, I guess I have the wrong person.");
                }
                else if(name.ToLower() == "alyssa")
                {
                    Console.WriteLine("PRINCESS?!?! I didn't recognize you! This is great news, let's go get married!");
                    Console.WriteLine("");
                    Console.WriteLine("(You found Alyssa's secret easter egg :) good job)");
                    Console.WriteLine("Press enter to exit the game");
                    Console.ReadLine();
                    return;
                }
            }
            switch (name.ToLower())
            {
                case "blake":
                    name = "Blake";
                    weapon = "Bailey Turd Blaster";
                    boss1 = "Uses turd blaster to shoot arm";
                    bossresult1 = "*Mr. Armisen's arm rots off*";
                    boss2 = "Aim Bailey's tail and light a flame underneath to shoot flaming turds at Nap Lord.";
                    groomsmanAsk = "We basically have the whole brother thing down so lets just make this official. \nBlake, will you be my groomsman!? ";
                    break;
                case "derek":
                    name = "Derek";
                    weapon = "Whiskey Molotov";
                    boss1 = "Take a sip then throw a whiskey molotov at the arm";
                    bossresult1 = "*Mr. Armisen's arm burns off*";
                    boss2 = "Take a sip then put a few whiskey molotovs in a pillowcase and swing it at Nap Lord.";
                    groomsmanAsk = "You've been such a good friend to me and I couldn't imagine not having you there on our big day. \nDerek, will you be my groomsman!?";
                    break;
                case "jordan":
                    name = "Jordan";
                    weapon = "Mizithra Cheese Bomb";
                    boss1 = "Throw cheese bomb at the arm";
                    bossresult1 = "*Mr. Armisen's arm melts off*";
                    boss2 = "Combine a bedsheet and a mizithra cheese bomb to throw over Nap Lord to create the biggest dutch oven.";
                    groomsmanAsk = "Brutha! Having your love and support on our big day would mean the world to me. \nJordan, will you be my groomsman!?";
                    break;
            }
            Console.WriteLine("The Princess has been kidnapped by the Loose Organization of Sulking Exiled Runner-upS or L.O.S.E.R.S");
            Console.WriteLine("as they appropriately call themselves. I have to rescue her before I can marry her.");
            Console.WriteLine("It is going to be a long and perilous errand and I can't do it by myself.");
            Console.WriteLine("I'm gonna need some help and was wondering if you had some time to kill.");
            Console.WriteLine("So whatdayasay!? Wanna go beat up some L.O.S.E.R.S?");
            while (response.ToLower() != "yes" && counter < 3)
            {
                Console.WriteLine("(Yes/No)");
                response = Console.ReadLine();
                if (response.ToLower() == "yes")
                {
                    Console.WriteLine("Awesome! I knew I could count on you.");
                }
                else if (response.ToLower() == "no" && counter == 0)
                {
                    Console.WriteLine("Are you sure it could be a lot of fun!? Take some time to think about it.");
                    counter++;
                }
                else if (response.ToLower() == "no" && counter == 1)
                {
                    Console.WriteLine("Is this not exciting for you!? Won't you reconsider!?");
                    counter++;
                }
                else if (response.ToLower() == "no" && counter == 2)
                {
                    Console.WriteLine("Sorry I annoyed you with my friendship! But I'm dragging you along anyways.");
                    counter++;
                }
                else
                {
                    Console.WriteLine("Sorry I don't speak Espanol");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("If I had the time I would put together a whole montage of us training and preparing for the battles ahead. ");
            Console.WriteLine("But we must act quickly, time is precious. It would dangerous to go alone so please take this:");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("*YOU GOT THE " + weapon.ToUpper() + "!!!*");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("I just received a menacing piece of mail saying that one of the members of the L.O.S.E.R.S");
            Console.WriteLine("wants to meet us at the local movie theater.");
            Console.WriteLine("This could be where they are keeping the princess. Are there any last minute things you need to take care of?");
            Console.WriteLine("You won't be able to return back later. (Yes/No)");
            response = Console.ReadLine();
            if (response.ToLower() == "yes")
            {
                Console.WriteLine("What did you need to do? (Pick a number)");
                Console.WriteLine("(1) Bathroom");
                Console.WriteLine("(2) Masturbate");
                Console.WriteLine("(3) Do my taxes");
                Console.WriteLine("(4) Finish my Christmas shopping");
                response = Console.ReadLine();
                if (response.Contains("1"))
                {
                    Console.WriteLine("I don't blame you I just had to go too, so the seat should be warm for you.");
                    Console.WriteLine("*You pooped. You and Josh head out.*");
                }
                else if(response.Contains("2"))
                {
                    Console.WriteLine("I don't blame you. I needed a quick release too, don't mind the used tissues in the trash.");
                    Console.WriteLine("*You choked your chicken. You and Josh head out.*");
                }
                else if(response.Contains("3"))
                {
                    Console.WriteLine("I don't blame you. It's important to pay your fair share.");
                    Console.WriteLine("*Way to adult. You and Josh head out.*");
                }
                else if (response.Contains("4"))
                {
                    Console.WriteLine("I don't blame you. Dad's are hard to shop for.");
                    Console.WriteLine("*Dad loves his new sweater. You and Josh head out.*");
                }
                else
                {
                    Console.WriteLine("I guess you didn't need to do anything. Let's go!");
                }
            }
            else if(response.ToLower() == "no")
            {
                Console.WriteLine("Cool. Let's go!");
            }
            else
            {
                Console.WriteLine("Not really sure what that means. But let's go!");
            }
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("*Josh and " + name + " pull up to the movie theater. The marquee board reads:*");
            Console.WriteLine("*ARMageddon, The ARM Wrestler 2: 2Biceps2Guns, Swiss ARMy Man, and Soul Surfer.*");
            Console.WriteLine("*They all happen to begin at 2:45 Josh and " + name +" get out of the car.*");
            Console.WriteLine("");
            Console.WriteLine("This movie theater seems to have a fascination with arms.");
            Console.WriteLine("Looks like we have enough time to grab some popcorn before the movie starts.");
            Console.WriteLine("");
            Console.WriteLine("(Pick a number)");
            Console.WriteLine("(1) Popcorn sounds great. Extra butter please.");
            Console.WriteLine("(2) Reflect on your own arms.");
            Console.WriteLine("(3) I was trying to think of a good arm pun, but I couldn't come up with anything humerus.");
            response = Console.ReadLine();
            if (response.Contains("1"))
            {
                Console.WriteLine("Don't forget the napkins.");
            }
            else if (response.Contains("2"))
            {
                Console.WriteLine("Don't worry man your tri's are popping!");
            }
            else if (response.Contains("3"))
            {
                Console.WriteLine("Oh you! *hits arm*");
            }
            else
            {
                Console.WriteLine("Ok. I guess we won't get any popcorn.");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("*Josh and " + name + " walk in after purchasing a movie ticket hoping to secure good seats.*");
            Console.WriteLine("*But instead walk into a room filled with blow-up arms flexing everywhere.*");
            Console.WriteLine("*A table is set up in the middle with a shadowy figure doing curls menacingly.*");
            Console.WriteLine("????: Took you long enough. If you are ever going to get your princess back you'll");
            Console.WriteLine("      have to beat me in an arm wrestling match.");
            Console.WriteLine("JOSH: Who are you and what did you do with my princess!?");
            Console.WriteLine("????: I am Mr. Armisen of course and I am a member of the L.O.S.E.R.S. Now are you prepared to lose?");
            Console.WriteLine("*Josh turns to " + name + "*");
            Console.WriteLine("JOSH: If this goes south are you gonna have my back?");
            Console.WriteLine("(Yes/No)");
            response = Console.ReadLine();
            if (response.ToLower() == "yes")
            {
                Console.WriteLine("You're the best!!!!!");
            }
            else
            {
                Console.WriteLine("Very funny " + name + ", you wouldn't be here if you didn't.");
            }
            Console.WriteLine("");
            Console.WriteLine("*Josh turns to Mr. Armisen*");
            Console.WriteLine("*JOSH: Alright weirdo! Let's wrastle!");
            Console.WriteLine("*Mr. Armisen and Josh approach the arm wrestling table and each take a seat.*");
            Console.WriteLine("*Josh grips Mr. Armisen's clammy moist hand. The battle begins.*");
            Console.WriteLine(name + " cheers! (Pick a number)");
            Console.WriteLine("(1) Whoop there it is!");
            Console.WriteLine("(2) Bazinga!");
            Console.WriteLine("(3) Don't dislocate your shoulder!");
            Console.WriteLine("(4) Do nothing. You do not want to throw off Josh's groove.");
            response = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("*The battle is intense and it seems to be going in Josh's favor.*");
            Console.WriteLine("*But then suddenly Mr. Armisen pulls out a syringe and injects steroids into his pulsating bicep.*");
            Console.WriteLine("*His bicep grows 10 sizes larger.*");
            Console.WriteLine("JOSH: That's cheating!");
            Console.WriteLine("MR A: ThAt'S cHeAtInG!");
            Console.WriteLine("*Mr. Armisen suddenly grabs Josh by the throat and lifts him off the ground.*");
            Console.WriteLine("");
            counter = 0;
            while (counter < 1)
            {
                Console.WriteLine("JOSH: This guy is insane! " + name + " help me!");
                Console.WriteLine("(Pick a number)");
                Console.WriteLine("(1) " + boss1);
                Console.WriteLine("(2) Kick Mr. Armisen in the balls");
                Console.WriteLine("(3) Do nothing");
                response = Console.ReadLine();
                if (response.Contains("1"))
                {
                    Console.WriteLine(bossresult1);
                    counter++;
                }
                else if (response.Contains("2"))
                {
                    Console.WriteLine("*Writhing in pain, Mr. Armisen grabs his balls and crushes them with his pure strength*");
                    counter++;
                }
                else
                {
                    Console.WriteLine("*JOSH DIES*");
                    Console.WriteLine("*Errand Failed. Returning to last checkpoint.");
                    Console.WriteLine("--------------------------------------------------------------------------------------");
                    Console.WriteLine("--------------------------------------------------------------------------------------");
                }
            }
            Console.WriteLine("*Mr. Armisen falls to the ground in agony and explodes into L.O.S.E.R loot*");
            Console.WriteLine("JOSH: What is a loser's favorite part of the body? Da-feet!!!");
            Console.WriteLine("*Before " + name + " can respond an ominous sleepy voice comes through the speakers overhead*");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("????: *Yawns* Josh and " + name + " you may have defeated Mr. Armisen but his pride got the best of him.");
            Console.WriteLine("      If you want to have your precious princess returned, you must face me, the NAP LORD!");
            Console.WriteLine("      I will wait for you in my chambers across the street at the Mattress Firm.");
            Console.WriteLine("JOSH: That was crazy! But it sounds like there are still more losers out there. Are you still willing to beat 'em up?");
            Console.WriteLine("(Pick a number)");
            Console.WriteLine("(1) How much longer!? This game is boring.");
            Console.WriteLine("(2) Sure, let's get this over with. I have real errands to run.");
            response = Console.ReadLine();
            if (response.Contains("1"))
            {
                Console.WriteLine("How dare you think of my life as a game. But honestly it should only take a few more hours.");
            }
            else if (response.Contains("2"))
            {
                Console.WriteLine("Perfect. So do I.");
            }
            else
            {
                Console.WriteLine("I love the intensity. Let's go get him!");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("*Josh and " + name + " gather as much L.O.S.E.R loot as they can fit in their pockets and kick open the front door.*");
            Console.WriteLine("*They make their way across the street to the Mattress Firm. As they enter, Josh notices the entire room is padded*");
            Console.WriteLine("*in mattresses. Josh and " + name + " enter and the Nap Lord is standing in front of a giant cross chanting.*");
            Console.WriteLine("*As they get closer Josh notices that his princess is tied to the cross and appears to be in a deep trance*");
            Console.WriteLine("*due to a white noise machine the Nap Lord has set up.*");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("JOSH: Nap Lord unhand the hand that is meant to be taken by my hand!");
            Console.WriteLine("LORD: God does not approve of your matrimony and neither do I! With the power of prayer on my side nothing can stop me.");
            Console.WriteLine("      God has bestowed upon me the most sacred of all pillows, to aid me in converting all nonbelievers.");
            Console.WriteLine("      But God is just, so I grant you a pillow also, go grab one from the clearance bin");
            Console.WriteLine("      and let's see what you got heathen!");
            Console.WriteLine("JOSH: Alright weirdo!");
            Console.WriteLine("");
            Console.WriteLine("*Josh grabs a lumpy pillow from the clearance bin and takes a swing. Nap Lord ducks.*");
            Console.WriteLine("*Nap Lord swings upwards hitting Josh in the jaw, launching him into the air and softly landing on the mattress floor*");
            Console.WriteLine(name + " help me!");
            Console.WriteLine("(Pick a number)");
            Console.WriteLine("(1) Lift Josh up and give him an encouraging pat on the butt");
            Console.WriteLine("(2) Use your " + weapon);
            Console.WriteLine("(3) Jump on mattresses");
            response = Console.ReadLine();
            if (response.Contains("1"))
            {
                Console.WriteLine("JOSH: Thanks bud, glad you're here with me!");
            }
            else if (response.Contains("2"))
            {
                Console.WriteLine("*The power of Christ protects Nap Lord from heathen weaponry.*");
                Console.WriteLine("*The distraction gives Josh enough time to get back on his feet.*");
            }
            else if (response.Contains("3"))
            {
                Console.WriteLine("*Your powerful bounce launches Josh back onto his feet*");
            }
            else
            {
                Console.WriteLine("*Josh sees the fear in your eyes and his protective instincts kick in.*");
                Console.WriteLine("*Josh kicks himself up off the ground.*");
            }
            Console.WriteLine("");
            Console.WriteLine("*Josh takes another swing at the Nap Lord and hits him in the jaw. The Nap Lord stumbles backwards.*");
            Console.WriteLine("*After regaining his balance he wipes away the blood from his mouth. With the Power of Christ the Nap Lord ascends into*");
            Console.WriteLine("*the air then body slams Josh into the ground and begins suffocating him with the holy pillow.*");
            Console.WriteLine("");
            counter = 0;
            while (counter < 1)
            {
                Console.WriteLine("JOSH: MmmMMrmrrrMmmRmmmmRMMMm");
                Console.WriteLine("(Pick a number)");
                Console.WriteLine("(1) " + boss2);
                Console.WriteLine("(2) Pray for Josh in these trying times.");
                Console.WriteLine("(3) Do nothing");
                response = Console.ReadLine();
                if (response.Contains("1"))
                {
                    Console.WriteLine("*God's protective barrier around Nap Lord is disabled and he is expelled off of Josh.*");
                    Console.WriteLine("*********************************************************************************");
                    Console.WriteLine("*With that heroic act of friendship Josh gains the ULTIMATE POWER.*");
                    Console.WriteLine("*********************************************************************************");
                    counter++;
                }
                else if (response.Contains("2"))
                {
                    Console.WriteLine("*God has finally answered a prayer. Josh’s new found holiness blinds Nap Lord, knocking him off of Josh.*");
                    Console.WriteLine("*********************************************************************************");
                    Console.WriteLine("*Josh gains the ULTIMATE POWER.*");
                    Console.WriteLine("*********************************************************************************");
                    counter++;
                }
                else
                {
                    Console.WriteLine("*JOSH DIES*");
                    Console.WriteLine("*Errand Failed. Returning to last checkpoint.");
                    Console.WriteLine("--------------------------------------------------------------------------------------");
                    Console.WriteLine("--------------------------------------------------------------------------------------");
                }
            }
            Console.WriteLine("*Now with the ultimate power at Josh’s possession he powers up his swing and hits the Nap Lord knocking the holy spirit*");
            Console.WriteLine("*right out of him. The spirit and Nap Lord's body vanish into thin air. L.O.S.E.R loot rains from the heavens.*");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("JOSH: If you need an ark, ask me. I Noah man!");
            Console.WriteLine("*Before " + name + " can respond the princess screams, \"Get me down from here!\"*");
            Console.WriteLine("*Josh goes and smashes the white noise machine then unties his princess.*");
            Console.WriteLine("JOSH: If it wasn't for " + name + ", I wouldn't have been able to ever save you.");
            Console.WriteLine("Now that we have saved the princess. I can finally marry her!");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(groomsmanAsk);
            response = "";
            counter = 0;
            while (response.ToLower() != "yes" && counter < 3)
            {
                Console.WriteLine("(Yes/No)");
                response = Console.ReadLine();
                if (response.ToLower() == "yes")
                {
                    Console.WriteLine("Great! I'll send you the bill later.");
                }
                else if (response.ToLower() == "no" && counter == 0)
                {
                    Console.WriteLine("Very Funny. But seriously will you?");
                    counter++;
                }
                else if (response.ToLower() == "no" && counter == 1)
                {
                    Console.WriteLine("Please I don't have that many options.");
                    counter++;
                }
                else if (response.ToLower() == "no" && counter == 2)
                {
                    Console.WriteLine("Good thing it's Opposite Day! I'll see you at the wedding.");
                    counter++;
                }
                else
                {
                    Console.WriteLine("Sorry I don't speak Chinese.");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("*Thank you for being my groomsman!*");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press enter to exit the game");
            Console.ReadLine();







        }
    }
}

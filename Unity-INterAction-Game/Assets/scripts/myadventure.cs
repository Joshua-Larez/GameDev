using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myadventure : MonoBehaviour
{
    //all current states of the game //
    private enum States
    {
        Storybeg,
        Storybeg1,
        Stoiry1,
        Stoiry2,
        Joinme,
        Stoiry3,
        Chokeher,
        Stoiry4,
        Lethergo,
        Stoiry5,
        Stoiry6,
        Againstwho,
        Stoiry7,
        Stoiry8,
        Whohighground,
        Stoiry9,
        JuMp,
        Stoiry10,
        Dead01,
        Endgame
    }

    private States currentState = States.Storybeg;

    //start page of the game //
    void Start()
    {
        Menu();
    }


    //start list of all functions //
    void Menu()//Begin Screen//
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welcome to The Chosen One");
        Terminal.WriteLine("This is a scene game based on Star Wars");
        Terminal.WriteLine("type start to begin");

    }

    void StoryBegin()//Storybeg1
    { 
        currentState = States.Storybeg1;
        Terminal.ClearScreen();
        Terminal.WriteLine("There was only sadness and horror");
        Terminal.WriteLine("then came the wife Padme and ");
        Terminal.WriteLine("there was a little relief");
        Terminal.WriteLine("Type next to continue");
    }

    void Story1()//Stoiry1
    {
        currentState = States.Stoiry1;
        Terminal.ClearScreen();
        Terminal.WriteLine("Padme Told You that Obi-Wan");
        Terminal.WriteLine("told her that you have changed");
        Terminal.WriteLine("and you are really different,");
        Terminal.WriteLine("but you tell her that you are");
        Terminal.WriteLine("doing this for her.");
        Terminal.WriteLine("Type next to continue");

    }

    void Story2()//Stoiry2
    {
        currentState = States.Stoiry2;
        Terminal.ClearScreen();
        Terminal.WriteLine("you begin to say that Padme");
        Terminal.WriteLine("should join you, then she said");
        Terminal.WriteLine("you are going a path ");
        Terminal.WriteLine("that she can't follow.");
        Terminal.WriteLine("Type next to continue ");

    }

    void JoinMe()//JoineMe
    {
        currentState = States.Joinme;
        Terminal.ClearScreen();
        Terminal.WriteLine("You proceed to tell Padme,");
        Terminal.WriteLine("That she should join you.");
        Terminal.WriteLine("join anakin or dont join ?");
    }

    void Story3()//Stoiry3
    {
        currentState = States.Stoiry3;
        Terminal.ClearScreen();
        Terminal.WriteLine("Then Obi-wan appears and you ");
        Terminal.WriteLine("begin saying that she is with ");
        Terminal.WriteLine("Obi-wan and she brought him to");
        Terminal.WriteLine("kill you. ");
        Terminal.WriteLine("Type next to continue");
    }

    void ChokeHer()//Chokeher
    {
        currentState = States.Chokeher;
        Terminal.ClearScreen();
        Terminal.WriteLine("Now you are angry and feel betrayed");
        Terminal.WriteLine("What do you do ??");
        Terminal.WriteLine("choke her or dont choke her ?");

    }

    void Story4()//Stoiry4
    {
        currentState = States.Stoiry4;
        Terminal.ClearScreen();
        Terminal.WriteLine("You now begin to Force choke ");
        Terminal.WriteLine("her and Obi-wan is telling you");
        Terminal.WriteLine("to let her go.");
        Terminal.WriteLine("Type next to continue");

    }

    void LetHerGo()//Lethergo
    {
        currentState = States.Lethergo;
        Terminal.ClearScreen();
        Terminal.WriteLine("You now have to decide");
        Terminal.WriteLine("let her go or dont let her go");
    }

    void Story5()//Stoiry5
    {
        currentState = States.Stoiry5;
        Terminal.ClearScreen();
        Terminal.WriteLine("you let her go and Obi-wan");
        Terminal.WriteLine("goes to check on her");
        Terminal.WriteLine("Type next to continue");

    }

    void Story6()//Stoiry6
    {
        currentState = States.Stoiry6;
        Terminal.ClearScreen();
        Terminal.WriteLine("You tell Obi-wan to join your");
        Terminal.WriteLine("new empire and if doesn't ");
        Terminal.WriteLine("he is against you.");
        Terminal.WriteLine("Type next to continue");

    }

    void AgainstWho()//Againstwho
    {
        currentState = States.Againstwho;
        Terminal.ClearScreen();
        Terminal.WriteLine("'He says his allegiance is to ");
        Terminal.WriteLine("the republic to democracy'");
        Terminal.WriteLine("What do you do ?");
        Terminal.WriteLine("Are you against him ?");
        Terminal.WriteLine("against him or not against him");
    }

    void Story7()//Stoiry7
    {
        currentState = States.Stoiry7;
        Terminal.ClearScreen();
        Terminal.WriteLine("Then you proceed to fight");
        Terminal.WriteLine("Obi-Wan in a Legendary Lightsaber Dual");
        Terminal.WriteLine("Type next to continue");

    }

    void Story8()//Stoiry8
    {
        currentState = States.Stoiry8;
        Terminal.ClearScreen();
        Terminal.WriteLine("Now your on a platform that's");
        Terminal.WriteLine("on lava infront of Obi-Wan");
        Terminal.WriteLine("Type next to continue");

    }

    void WhoHighGround()//Whohighground
    {
        currentState = States.Whohighground;
        Terminal.ClearScreen();
        Terminal.WriteLine("Who has the highground?");
        Terminal.WriteLine("i have or he has ?");
    }

    void Story9()//Stoiry9
    {
        currentState = States.Stoiry9;
        Terminal.ClearScreen();
        Terminal.WriteLine("Obi-Wan:");
        Terminal.WriteLine("Anakin don't try it!");
        Terminal.WriteLine("Type next to continue");

    }

    void Jump()//JuMp
    {
        currentState = States.JuMp;
        Terminal.ClearScreen();
        Terminal.WriteLine("Now you want to really kill Obi-wan");
        Terminal.WriteLine("but you are not sure what to do");
        Terminal.WriteLine("and you think you are ");
        Terminal.WriteLine("gonna jumpkill him");
        Terminal.WriteLine("what do you do ?");
        Terminal.WriteLine("jump or dont jump");
    }

    void Story10()//Stoiry10
    {
        currentState = States.Stoiry10;
        Terminal.ClearScreen();
        Terminal.WriteLine("You proceed to jump attack Obi-wan");
        Terminal.WriteLine("Type next to continue");

    }

    void Dead1()//Dead01
    {
        currentState = States.Dead01;
        Terminal.ClearScreen();
        Terminal.WriteLine("Obi-wan does a awesome slicecut and ");
        Terminal.WriteLine("cuts all your limbs");
        Terminal.WriteLine("and he leaves you laying down");
        Terminal.WriteLine("to die slowly.");
        Terminal.WriteLine("click Enter");
    }

    void EndGame()//Endgame
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine("Thank You For Playing This Game");
    }


    //end list of all functions//


    //start userinput (everything that the user/player types in) //
    void OnUserInput(string input)
    {
        if (currentState == States.Storybeg)
        {
            if (input == "start")
            {
                StoryBegin(); 
            }
            else
            {
                Terminal.WriteLine("Wrong Input!!");
            }
        }
        else if (currentState == States.Storybeg1)
        {
            if (input == "next")
            {
                Story1();
            }
            else
            {
                Terminal.WriteLine("Wrong Input!!");
            }
        }
        else if (currentState == States.Stoiry1)
        {
            if (input == "next")
            {
                Story2();
            }
            else
            {
                Terminal.WriteLine("Wrong Input!!");
            }
        }
        else if (currentState == States.Stoiry2)
        {
            if (input == "next")
            {
                JoinMe();
            }
            else
            {
                Terminal.WriteLine("Wrong Input!!");
            }
        }
        else if (currentState == States.Joinme)
        {
            if (input == "dont join")
            {
                Story3();
            }
            else
            {
                Terminal.WriteLine("Wrong Input!!");
            }
        }
        else if (currentState == States.Stoiry3)
        {
            if (input == "next")
            {
                ChokeHer();
            }
            else
            {
                Terminal.WriteLine("Wrong Input!!");
            }
        }
        else if (currentState == States.Chokeher)
        {
            if (input == "choke her")
            {
                Story4();
            }
            else
            {
                Terminal.WriteLine("Wrong Input!!");
            }
        }
        else if (currentState == States.Stoiry4)
        { 
            if (input == "next")
            {
                LetHerGo();
            }
            else
            {
                Terminal.WriteLine("Wrong Input!!");
            }
        }
        else if (currentState == States.Lethergo)
        {
            if (input == "let her go")
            {
                Story5();
            }
            else
            {
                Terminal.WriteLine("Wrong Input!!");
            }

        }
        else if (currentState == States.Stoiry5)
        {
            if (input == "next")
            {
                Story6();
            }
            else
            {
                Terminal.WriteLine("Wrong Input!!");
            }

        }
        else if (currentState == States.Stoiry6)
        {
            if (input == "next")
            {
                AgainstWho();
            }
            else
            {
                Terminal.WriteLine("Wrong Input!!");
            }

        }
        else if (currentState == States.Againstwho)
        {
            if (input == "against him")
            {
                Story7();
            }
            else
            {
                Terminal.WriteLine("Wrong Input!!");
            }

        }
        else if (currentState == States.Stoiry7)
        {
            if (input == "next")
            {
                Story8();
            }
            else
            {
                Terminal.WriteLine("Wrong Input!!");
            }

        }
        else if (currentState == States.Stoiry8)
        {
            if (input == "next")
            {
                WhoHighGround();
            }
            else
            {
                Terminal.WriteLine("Wrong Input!!");
            }

        }
        else if (currentState == States.Whohighground)
        {
            if (input == "i have")
            {
                Story9();
            }
            else
            {
                Terminal.WriteLine("Wrong Input!!");
            }

        }
        else if (currentState == States.Stoiry9)
        {
            if (input == "next")
            {
                Jump();
            }
            else
            {
                Terminal.WriteLine("Wrong Input!!");
            }

        }
        else if (currentState == States.JuMp)
        {
            if (input == "jump")
            {
                Story10();
            }
            else
            {
                Terminal.WriteLine("Wrong Input!!");
            }

        }
        else if (currentState == States.Stoiry10)
        {
            if (input == "next")
            {
                Dead1();
            }
            else
            {
                Terminal.WriteLine("Wrong Input!!");
            }

        }
        else if (currentState == States.Dead01)
        {
            EndGame();
        }
    }

}

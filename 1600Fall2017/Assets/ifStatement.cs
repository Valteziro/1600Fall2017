﻿using UnityEngine;
using UnityEngine.UI;

public class ifStatement : MonoBehaviour
{
<<<<<<< HEAD
    public bool canPlayGame = false;

    public Text input;
    public string password = "G@m3Pl@y";
    public Toggle toggle;
    // Use this for initialization
=======

    public int num1;
    public int num2;
    public int value;
    public int value2;
    public int value3;

    public bool canPlay;
    public bool False; 

    public Text input;
    private string password = "G@m3Pl@y";

>>>>>>> master
    void Update()
    
    {
        if (input.text == password)
        {
            print("You know the password");
            canPlayGame = true;
        }
        else
<<<<<<< HEAD
        {
            print("the password is incorrect.");
=======
        {
            print("That's Wrong.")
        }

        if (num1 * num2 == value2)
        {
            print(value2)
        }
        else
        {
            print("That's Wrong.")
        }

        if (num1 % num2 == value3)
        {
            print(value3)
        }
        else
        {
            print("That's Wrong.")
        }

        if (canPlay)
        {
            print("Play.");
        }
        else
        {
            print("Can't Play.")
>>>>>>> master
        }
        if(canPlayGame)
        {
            print("Playing Game");
        }
        else
        {
            print("Can't play yet, enter a correct password.");
        }
        if (toggle.IsOn);
        {
            print("Playing Game");
        }
        else 
        {
            print("Game Cannot Be Played.");
        }
        else
        {
            print("That's The Wrong Password.")
        }

        if (False)
        {
            print("It's False, therefore True")
        }
        else
        {
            print("It's True, therfore False")
        }
    }
}
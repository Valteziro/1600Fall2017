using UnityEngine;
using UnityEngine.UI;

public class ifStatement : MonoBehaviour
{

    public int num1;
    public int num2;
    public int value;
    public int value2;
    public int value3;

    public bool canPlay;
    public bool False; 

    public Text input;
    private string password = "G@m3Pl@y";

    void Update()
    
    {
        if (num1 + num2 == value)
        {
            print(value);
        }
        else
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
        }

        if (input.text == password)
        {
            print("You know the password");
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
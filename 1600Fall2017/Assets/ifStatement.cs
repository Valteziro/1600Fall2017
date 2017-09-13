using UnityEngine;
using UnityEngine.UI;

public class ifStatement : MonoBehaviour
{
    public bool canPlayGame = false;

    public Text input;
    public string password = "G@m3Pl@y";
    public Toggle toggle;
    // Use this for initialization
    void Update()
    {
        if (input.text == password)
        {
            print("You know the password");
            canPlayGame = true;
        }
        else
        {
            print("the password is incorrect.");
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
    }
}
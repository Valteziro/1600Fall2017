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

        if (num1 * num2 == value2)
        {
            print(value2)
        }

        if (num1 % num2 == value3)
        {
            print(value3)
        }

        if 

        if (canPlay)
        {
            print("Play");
        }

        if (input.text == password)
        {
            print("You know the password");
        }

        if (False)
        {
            print("It's False, therefore True")
        }
    }
}
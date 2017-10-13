using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccess : MonoBehaviour
{
    //These can be called anywhere as they are fields.

    //These have the private access modifier, meaning they can only be called in this script.
    private int health = 100;
    private string MyString = "This is a string.";
    private bool MyBool = true;
    private float MyFloat = 2.5f;
    private double MyDouble = 2.5;
    
    //These have the public access modifier, meaning they can be called in other scripts.
    public int score = 100;
    public string MyString2 = "This is also a string.";
    public bool MyBool2 = true;
    public float MyFloat2 = 2.5f;
    public double MyDouble2 = 2.5;

    private void Start()
    {
        //These cannot be called anywhere as they are in brackets.
        int NewScore = 10;
        print(NewScore);
    }


}
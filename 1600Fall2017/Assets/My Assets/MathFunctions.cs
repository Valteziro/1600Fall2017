using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathFunctions : MonoBehaviour
{
    public int MyScore = 100;
    public int Health;
    public int Ammo;
    public string MyPassword = "Password";

    void Start()
    {
        MyScore = ReturnNum(Health, Ammo);
        MyPassword = ReturnPassword(MyPassword);
    }

    int ReturnNum(int _num1, int _num2)
    {
        return _num1 + _num2;
    }

    string ReturnPassword(string _login)
    {
        if (_login == "ou812")
        {
            return "Password";
        }
        else
        {
            return "Incorrect";
        }
    } 
}